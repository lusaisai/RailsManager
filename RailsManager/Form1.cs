using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private RailsApp a;

        private void start_Click(object sender, EventArgs e)
        {
            a = new RailsApp(@"C:\Ruby193\bin\rails.bat", @"C:\projects\V");
            a.run("development", 3000);
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            a.stop("development");
        }


    }
}
