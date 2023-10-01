namespace launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenSimulator = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.btnCloseSim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenSimulator
            // 
            this.btnOpenSimulator.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpenSimulator.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpenSimulator.Location = new System.Drawing.Point(388, 8);
            this.btnOpenSimulator.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenSimulator.Name = "btnOpenSimulator";
            this.btnOpenSimulator.Size = new System.Drawing.Size(260, 260);
            this.btnOpenSimulator.TabIndex = 0;
            this.btnOpenSimulator.Text = "اجرای شبیه ساز";
            this.btnOpenSimulator.UseVisualStyleBackColor = false;
            this.btnOpenSimulator.Click += new System.EventHandler(this.btnOpenSimulator_Click);
            this.btnOpenSimulator.MouseEnter += new System.EventHandler(this.btnOpenSimulator_MouseEnter);
            this.btnOpenSimulator.MouseLeave += new System.EventHandler(this.btnOpenSimulator_MouseLeave);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGame.BackgroundImage")));
            this.btnGame.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGame.Location = new System.Drawing.Point(35, 8);
            this.btnGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(260, 260);
            this.btnGame.TabIndex = 1;
            this.btnGame.Text = "اجرای بازی";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            this.btnGame.MouseEnter += new System.EventHandler(this.btnGame_MouseEnter);
            this.btnGame.MouseLeave += new System.EventHandler(this.btnGame_MouseLeave);
            // 
            // btnBoth
            // 
            this.btnBoth.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBoth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoth.BackgroundImage")));
            this.btnBoth.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBoth.Location = new System.Drawing.Point(388, 400);
            this.btnBoth.Margin = new System.Windows.Forms.Padding(0);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(260, 260);
            this.btnBoth.TabIndex = 2;
            this.btnBoth.Text = "اجرای بازی و شبیه ساز";
            this.btnBoth.UseVisualStyleBackColor = false;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            this.btnBoth.MouseEnter += new System.EventHandler(this.btnBoth_MouseEnter);
            this.btnBoth.MouseLeave += new System.EventHandler(this.btnBoth_MouseLeave);
            // 
            // btnCloseSim
            // 
            this.btnCloseSim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCloseSim.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCloseSim.Location = new System.Drawing.Point(35, 400);
            this.btnCloseSim.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseSim.Name = "btnCloseSim";
            this.btnCloseSim.Size = new System.Drawing.Size(260, 260);
            this.btnCloseSim.TabIndex = 3;
            this.btnCloseSim.Text = "بستن شبیه ساز";
            this.btnCloseSim.UseVisualStyleBackColor = false;
            this.btnCloseSim.Click += new System.EventHandler(this.btnCloseSim_Click);
            this.btnCloseSim.MouseEnter += new System.EventHandler(this.btnCloseSim_MouseEnter);
            this.btnCloseSim.MouseLeave += new System.EventHandler(this.btnCloseSim_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(669, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseSim);
            this.Controls.Add(this.btnBoth);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnOpenSimulator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMXMELODY Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSimulator;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Button btnCloseSim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

