using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();



            Rectangle paddedRectangle = new Rectangle(
    btnBoth.ClientRectangle.Left + 3,
    btnBoth.ClientRectangle.Top  + 3,
    btnBoth.ClientRectangle.Width - 7,
    btnBoth.ClientRectangle.Height - 7
);
            path.AddEllipse(paddedRectangle);

            btnBoth.Region = new Region(path);
            btnOpenSimulator.Region = new Region(path);
            btnGame.Region = new Region(path);
            btnCloseSim.Region = new Region(path);
            pictureBox1.Region = new Region(path);

            //btnOpenSimulator.FlatAppearance.BorderColor = Color.White; // Set the outline color
            //btnOpenSimulator.FlatAppearance.BorderSize = 10; // Set the outline thickness

        }

        private void btnOpenSimulator_Click(object sender, EventArgs e)
        {
            string SimulatorPath = AppContext.BaseDirectory + "ExerciseGame.exe";
            if (System.Diagnostics.Process.GetProcessesByName("ExerciseGame").Count() == 0)
            {
                
                System.Diagnostics.Process.Start(SimulatorPath);
            }
            formPB fpb = new formPB();
            fpb.ShowDialog();
            
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("camXmelody").Count() == 0)
            {
                string GamePath = AppContext.BaseDirectory + "camXmelody.exe";
                System.Diagnostics.Process.Start(GamePath);
            }
            formPB fpb = new formPB();
            fpb.ShowDialog();

        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            string SimulatorPath = AppContext.BaseDirectory + "ExerciseGame.exe";
            if (System.Diagnostics.Process.GetProcessesByName("ExerciseGame").Count() == 0)
            {
                System.Diagnostics.Process.Start(SimulatorPath);
                
            }
            if (System.Diagnostics.Process.GetProcessesByName("camXmelody").Count() == 0)
            {
                string GamePath = AppContext.BaseDirectory + "camXmelody.exe";
                System.Diagnostics.Process.Start(GamePath);
            }
            formPB fpb = new formPB();
            fpb.ShowDialog();
        }

        private void btnCloseSim_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void btnOpenSimulator_MouseEnter(object sender, EventArgs e)
        {
            btnOpenSimulator.ForeColor = Color.White;

        }

        private void btnOpenSimulator_MouseLeave(object sender, EventArgs e)
        {
            btnOpenSimulator.ForeColor = Color.Black;
        }

        private void btnGame_MouseEnter(object sender, EventArgs e)
        {
            btnGame.ForeColor = Color.White;
        }

        private void btnGame_MouseLeave(object sender, EventArgs e)
        {
            btnGame.ForeColor = Color.Black;
        }

        private void btnBoth_MouseEnter(object sender, EventArgs e)
        {
            btnBoth.ForeColor = Color.White;
        }

        private void btnBoth_MouseLeave(object sender, EventArgs e)
        {
            btnBoth.ForeColor = Color.Black;
        }

        private void btnCloseSim_MouseEnter(object sender, EventArgs e)
        {
            btnCloseSim.ForeColor = Color.White;
        }

        private void btnCloseSim_MouseLeave(object sender, EventArgs e)
        {
            btnCloseSim.ForeColor = Color.Black;
        }
    }

    //public class CircularButton : Button
    //{
    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        GraphicsPath path = new GraphicsPath();
    //        path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        this.Region = new Region(path);

    //        base.OnPaint(e);
    //    }
    //}

}
