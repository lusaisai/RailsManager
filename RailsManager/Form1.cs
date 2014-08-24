using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

namespace RailsManager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addNewApp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if( DialogResult.OK == f.ShowDialog() ) {
                if (Properties.Settings.Default.apps == null) Properties.Settings.Default.apps = new ArrayList();
                if (! Properties.Settings.Default.apps.Contains(f.SelectedPath)) Properties.Settings.Default.apps.Add(f.SelectedPath);
                Properties.Settings.Default.Save();
                loadList();
            }
        }

        private void loadList()
        {
            list.Items.Clear();
            foreach (string app in Properties.Settings.Default.apps)
            {
                ListViewItem li = new ListViewItem(app);
                
                if ( new RailsApp(Properties.Settings.Default.railsExe, app).isRunning ) {
                    li.SubItems.Add("Running");
                } else {
                    li.SubItems.Add("Not Running");
                }
                list.Items.Add(li);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.railsExe == null) setRailsExecutable_Click(this, EventArgs.Empty);
            loadList();
            autoStart();
            Timer t = new Timer();
            t.Interval = 1500;
            t.Tick += (object s, EventArgs ea) => { this.Hide(); t.Stop(); };
            t.Start();
        }

        private void removeApp_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems != null)
            {
                foreach ( ListViewItem li in list.SelectedItems ) {
                    Properties.Settings.Default.apps.Remove(li.SubItems[0].Text);
                }
                Properties.Settings.Default.Save();
                loadList();
            }
        }

        private void runApp_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems != null)
            {
                runApp.Enabled = false;
                foreach (ListViewItem li in list.SelectedItems)
                {
                    startApp(li); 
                }
                runApp.Enabled = true;
            }
        }

        private void autoStart()
        {
            foreach (ListViewItem li in list.Items)
            {
                startApp(li); 
            }
        }

        private void startApp( ListViewItem li )
        {
            li.SubItems[1].Text = "Starting";
            RailsApp app = startRails(li.SubItems[0].Text);
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += (object s, EventArgs ea) =>
            {
                if (app.isRunning)
                {
                    loadList();
                    tmr.Stop();
                }
            };
            tmr.Start();
        }

        private RailsApp startRails(String appPath)
        {
            RailsApp app = new RailsApp(Properties.Settings.Default.railsExe, appPath);
            app.run("development", 3000);
            return app;
        }

        private void stopRails(String appPath)
        {
            RailsApp app = new RailsApp(Properties.Settings.Default.railsExe, appPath);
            app.stop();
        }

        private void stopApp_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems != null)
            {
                runApp.Enabled = false;
                foreach (ListViewItem li in list.SelectedItems)
                {
                    stopRails(li.SubItems[0].Text);
                    loadList();
                }
                runApp.Enabled = true;
            }
            
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void setRailsExecutable_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "rails script|rails.bat";
            if (DialogResult.OK == f.ShowDialog())
            {
                Properties.Settings.Default.railsExe = f.FileName;
                Properties.Settings.Default.Save();
            }

        }

        private void toTray_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
            if ( this.Visible ) 
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }


    }
}
