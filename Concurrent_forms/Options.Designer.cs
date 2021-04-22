namespace Concurrent_forms
{
    partial class Options
    {
        public System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.sound_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            this.exit_btn.Image = global::Concurrent_forms.Properties.Resources.left_arr_default;
            this.exit_btn.Location = new System.Drawing.Point(29, 27);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(150, 150);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 10;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.exit_btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            this.volume_bar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.volume_bar.Location = new System.Drawing.Point(398, 266);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volume_bar.Size = new System.Drawing.Size(306, 45);
            this.volume_bar.TabIndex = 11;
            this.volume_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volume_bar.Value = 25;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            this.sound_btn.BackColor = System.Drawing.Color.Transparent;
            this.sound_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_btn.BackgroundImage")));
            this.sound_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sound_btn.Location = new System.Drawing.Point(305, 253);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(76, 68);
            this.sound_btn.TabIndex = 12;
            this.sound_btn.TabStop = false;
            this.pictureBox1.Image = global::Concurrent_forms.Properties.Resources.intro_bg;
            this.pictureBox1.Location = new System.Drawing.Point(246, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox2.Image = global::Concurrent_forms.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(246, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 37);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.volume_bar);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox exit_btn;
        public System.Windows.Forms.TrackBar volume_bar;
        public System.Windows.Forms.PictureBox sound_btn;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}