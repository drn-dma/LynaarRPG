namespace Lynaar_GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_LoginMain = new System.Windows.Forms.Panel();
            this.picBox_VolumeOnOff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_VolumeOnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 219);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 219);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_LoginMain
            // 
            this.pnl_LoginMain.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LoginMain.Location = new System.Drawing.Point(16, 241);
            this.pnl_LoginMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_LoginMain.Name = "pnl_LoginMain";
            this.pnl_LoginMain.Size = new System.Drawing.Size(1035, 298);
            this.pnl_LoginMain.TabIndex = 6;
            // 
            // picBox_VolumeOnOff
            // 
            this.picBox_VolumeOnOff.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Volume_On;
            this.picBox_VolumeOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_VolumeOnOff.Location = new System.Drawing.Point(7, 479);
            this.picBox_VolumeOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.picBox_VolumeOnOff.Name = "picBox_VolumeOnOff";
            this.picBox_VolumeOnOff.Size = new System.Drawing.Size(88, 69);
            this.picBox_VolumeOnOff.TabIndex = 0;
            this.picBox_VolumeOnOff.TabStop = false;
            this.picBox_VolumeOnOff.Click += new System.EventHandler(this.OnOffSound);
            this.picBox_VolumeOnOff.MouseEnter += new System.EventHandler(this.picBox_VolumeOnOff_MouseEnter);
            this.picBox_VolumeOnOff.MouseLeave += new System.EventHandler(this.picBox_VolumeOnOff_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.picBox_VolumeOnOff);
            this.Controls.Add(this.pnl_LoginMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "LoginForm";
            this.Text = "Lynaar - Login";
            this.Load += new System.EventHandler(this.LoggingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_VolumeOnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_LoginMain;
        private System.Windows.Forms.PictureBox picBox_VolumeOnOff;
    }
}