using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
    
    public partial class formPB : Form
    {
        int count = 0;
        public formPB()
        {
            InitializeComponent();
            timer1.Enabled = true;
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            progressBar1.Value = count;
            if (count == 4)
                this.Close();
        }
    }
}
