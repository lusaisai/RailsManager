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

        private int selectedAppIndex = -1;

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
            if (Properties.Settings.Default.apps == null) return;
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
            if (Properties.Settings.Default.railsExe == null || !Properties.Settings.Default.railsExe.Contains("rails")) setRailsExecutable_Click(this, EventArgs.Empty);
            if (Properties.Settings.Default.config == null) Properties.Settings.Default.config = new ArrayList();
            Properties.Settings.Default.Save();
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
                list.Items[li.Index].Selected = true;
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

            app.run(env.Text, (int)port.Value);
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
            stopApp_Click(null, EventArgs.Empty);
            list.Items[this.selectedAppIndex].Selected = true;
            runApp_Click(null, EventArgs.Empty);
        }

        private void setRailsExecutable_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "rails script|rails.bat";
            f.Title = "Please browse and choose the rails.bat file";
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


        private void list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ( list.SelectedItems.Count < 1 ) return;
            int index = list.SelectedItems[0].Index;
            this.selectedAppIndex = index;        

            if ( Properties.Settings.Default.config.Count > index )
            {
                string[] s = ((string)(Properties.Settings.Default.config[index])).Split('|');
                env.Text = s[0];
                port.Value = Convert.ToInt32( s[1] );

            }
            else
            {
                env.SelectedIndex = 0;
                Properties.Settings.Default.config.Add( env.Text + "|" + port.Value );
                Properties.Settings.Default.Save();
            }

        }

        private void env_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void port_ValueChanged(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void saveConfig()
        {
            if (this.selectedAppIndex < 0) return;
            try
            {
                Properties.Settings.Default.config[this.selectedAppIndex] = env.Text + "|" + port.Value;
                Properties.Settings.Default.Save();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }


    }
}
