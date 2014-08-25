namespace RailsManager
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.addNewApp = new System.Windows.Forms.ToolStripButton();
            this.removeApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runApp = new System.Windows.Forms.ToolStripButton();
            this.stopApp = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setRailsExecutable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toTray = new System.Windows.Forms.ToolStripButton();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.env = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 6;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(0, 0);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 5;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.Location = new System.Drawing.Point(12, 42);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(555, 171);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rails Application Path";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 150;
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewApp,
            this.removeApp,
            this.toolStripSeparator2,
            this.runApp,
            this.stopApp,
            this.refresh,
            this.toolStripSeparator1,
            this.setRailsExecutable,
            this.toolStripSeparator3,
            this.toTray});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(580, 39);
            this.tools.TabIndex = 4;
            this.tools.Text = "toolStrip1";
            // 
            // addNewApp
            // 
            this.addNewApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewApp.Image = ((System.Drawing.Image)(resources.GetObject("addNewApp.Image")));
            this.addNewApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewApp.Name = "addNewApp";
            this.addNewApp.Size = new System.Drawing.Size(36, 36);
            this.addNewApp.Text = "toolStripButton1";
            this.addNewApp.ToolTipText = "Add a new Rails app";
            this.addNewApp.Click += new System.EventHandler(this.addNewApp_Click);
            // 
            // removeApp
            // 
            this.removeApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeApp.Image = ((System.Drawing.Image)(resources.GetObject("removeApp.Image")));
            this.removeApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeApp.Name = "removeApp";
            this.removeApp.Size = new System.Drawing.Size(36, 36);
            this.removeApp.Text = "toolStripButton1";
            this.removeApp.ToolTipText = "Remove selected Rails app";
            this.removeApp.Click += new System.EventHandler(this.removeApp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // runApp
            // 
            this.runApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runApp.Image = ((System.Drawing.Image)(resources.GetObject("runApp.Image")));
            this.runApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runApp.Name = "runApp";
            this.runApp.Size = new System.Drawing.Size(36, 36);
            this.runApp.Text = "toolStripButton1";
            this.runApp.ToolTipText = "Run the selected Rails app";
            this.runApp.Click += new System.EventHandler(this.runApp_Click);
            // 
            // stopApp
            // 
            this.stopApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopApp.Image = ((System.Drawing.Image)(resources.GetObject("stopApp.Image")));
            this.stopApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopApp.Name = "stopApp";
            this.stopApp.Size = new System.Drawing.Size(36, 36);
            this.stopApp.Text = "toolStripButton1";
            this.stopApp.ToolTipText = "Stop the selected Rails app";
            this.stopApp.Click += new System.EventHandler(this.stopApp_Click);
            // 
            // refresh
            // 
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(36, 36);
            this.refresh.Text = "toolStripButton1";
            this.refresh.ToolTipText = "Refresh the status";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // setRailsExecutable
            // 
            this.setRailsExecutable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setRailsExecutable.Image = ((System.Drawing.Image)(resources.GetObject("setRailsExecutable.Image")));
            this.setRailsExecutable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setRailsExecutable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setRailsExecutable.Name = "setRailsExecutable";
            this.setRailsExecutable.Size = new System.Drawing.Size(36, 36);
            this.setRailsExecutable.Text = "toolStripButton1";
            this.setRailsExecutable.ToolTipText = "Set the rails.bat file";
            this.setRailsExecutable.Click += new System.EventHandler(this.setRailsExecutable_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toTray
            // 
            this.toTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toTray.Image = ((System.Drawing.Image)(resources.GetObject("toTray.Image")));
            this.toTray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toTray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toTray.Name = "toTray";
            this.toTray.Size = new System.Drawing.Size(36, 36);
            this.toTray.Text = "toolStripButton1";
            this.toTray.ToolTipText = "Minimize to Tray";
            this.toTray.Click += new System.EventHandler(this.toTray_Click);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Rails Manager";
            this.tray.Visible = true;
            this.tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Environment";
            // 
            // env
            // 
            this.env.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.env.FormattingEnabled = true;
            this.env.Items.AddRange(new object[] {
            "development",
            "test",
            "production"});
            this.env.Location = new System.Drawing.Point(102, 249);
            this.env.Name = "env";
            this.env.Size = new System.Drawing.Size(121, 22);
            this.env.TabIndex = 8;
            this.env.SelectedIndexChanged += new System.EventHandler(this.env_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port.Location = new System.Drawing.Point(319, 249);
            this.port.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.port.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(120, 22);
            this.port.TabIndex = 10;
            this.port.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.port.ValueChanged += new System.EventHandler(this.port_ValueChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 315);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.env);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.list);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Rails Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton addNewApp;
        private System.Windows.Forms.ToolStripButton removeApp;
        private System.Windows.Forms.ToolStripButton runApp;
        private System.Windows.Forms.ToolStripButton stopApp;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton setRailsExecutable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toTray;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox env;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown port;
    }
}

