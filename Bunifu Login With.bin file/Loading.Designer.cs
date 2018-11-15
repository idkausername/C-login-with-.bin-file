namespace Bunifu_Login_With.bin_file
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.Progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuCards1.Controls.Add(this.Progressbar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-8, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(814, 458);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // Progressbar
            // 
            this.Progressbar.animated = true;
            this.Progressbar.animationIterval = 5;
            this.Progressbar.animationSpeed = 300;
            this.Progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progressbar.BackgroundImage")));
            this.Progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progressbar.ForeColor = System.Drawing.Color.SeaGreen;
            this.Progressbar.LabelVisible = true;
            this.Progressbar.LineProgressThickness = 8;
            this.Progressbar.LineThickness = 5;
            this.Progressbar.Location = new System.Drawing.Point(318, 108);
            this.Progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progressbar.MaxValue = 100;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Progressbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Progressbar.Size = new System.Drawing.Size(201, 201);
            this.Progressbar.TabIndex = 1;
            this.Progressbar.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Progressbar;
        private System.Windows.Forms.Timer timer1;
    }
}