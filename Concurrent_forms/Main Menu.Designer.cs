namespace Concurrent_forms
{
    partial class main_menu
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.newgame_btn = new System.Windows.Forms.Button();
            this.levels_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.options_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            this.newgame_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newgame_btn.FlatAppearance.BorderSize = 0;
            this.newgame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newgame_btn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame_btn.Image = global::Concurrent_forms.Properties.Resources.newgame_default;
            this.newgame_btn.Location = new System.Drawing.Point(65, 351);
            this.newgame_btn.Name = "newgame_btn";
            this.newgame_btn.Size = new System.Drawing.Size(430, 155);
            this.newgame_btn.TabIndex = 0;
            this.newgame_btn.UseVisualStyleBackColor = false;
            this.newgame_btn.Click += new System.EventHandler(this.newgame_btn_Click);
            this.newgame_btn.MouseLeave += new System.EventHandler(this.newgame_btn_MouseLeave);
            this.newgame_btn.MouseHover += new System.EventHandler(this.newgame_btn_MouseHover);
            this.levels_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.levels_btn.FlatAppearance.BorderSize = 0;
            this.levels_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levels_btn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levels_btn.Image = global::Concurrent_forms.Properties.Resources.lvl_sel_default;
            this.levels_btn.Location = new System.Drawing.Point(501, 351);
            this.levels_btn.Name = "levels_btn";
            this.levels_btn.Size = new System.Drawing.Size(426, 155);
            this.levels_btn.TabIndex = 1;
            this.levels_btn.UseVisualStyleBackColor = true;
            this.levels_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.levels_btn_MouseClick);
            this.levels_btn.MouseLeave += new System.EventHandler(this.levels_btn_MouseLeave);
            this.levels_btn.MouseHover += new System.EventHandler(this.levels_btn_MouseHover);
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(501, 528);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(426, 147);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_Click);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            this.exit_btn.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            this.options_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.options_btn.FlatAppearance.BorderSize = 0;
            this.options_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_btn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.options_btn.Image = global::Concurrent_forms.Properties.Resources.options_default;
            this.options_btn.Location = new System.Drawing.Point(65, 528);
            this.options_btn.Name = "options_btn";
            this.options_btn.Size = new System.Drawing.Size(430, 147);
            this.options_btn.TabIndex = 5;
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.options_btn_MouseClick);
            this.options_btn.MouseLeave += new System.EventHandler(this.options_btn_MouseLeave);
            this.options_btn.MouseHover += new System.EventHandler(this.options_btn_MouseHover);
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Concurrent_forms.Properties.Resources.biglogo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(102, 252);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(251, 44);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 728);
            this.Controls.Add(this.options_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.levels_btn);
            this.Controls.Add(this.newgame_btn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "main_menu";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button newgame_btn;
        public System.Windows.Forms.Button levels_btn;
        public System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Button options_btn;
        public System.Windows.Forms.PictureBox pictureBox1;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

