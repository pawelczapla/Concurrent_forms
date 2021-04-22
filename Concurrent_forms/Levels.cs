using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrent_forms
{
    public partial class Levels : Form
    {
        public Levels()
        { 
            InitializeComponent();
        }
        public void level1_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level1_btn.Image = Properties.Resources.lvl1_keyin;   
        }
        public void level2_btn_MouseHover_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level2_btn.Image = Properties.Resources.lvl2_keyin;   
        }
        public void level3_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level3_btn.Image = Properties.Resources.lvl3_keyin;   
        }
        public void level4_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level4_btn.Image = Properties.Resources.lvl4_keyin;   
        }
        public void level5_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level5_btn.Image = Properties.Resources.lvl5_keyin;   
        }
        public void level6_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level6_btn.Image = Properties.Resources.lvl6_keyin;   
        }
        public void level7_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level7_btn.Image = Properties.Resources.lvl7_keyin;   
        }
        public void level8_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            level8_btn.Image = Properties.Resources.lvl8_keyin;   
        }
        public void level1_btn_MouseLeave(object sender, EventArgs e)
        {
           level1_btn.Image = Properties.Resources.lvl1_default;    
        }
        public void level2_btn_MouseLeave(object sender, EventArgs e)
        {
            level2_btn.Image = Properties.Resources.lvl2_default;    
        }
        public void level3_btn_MouseLeave(object sender, EventArgs e)
        {
            level3_btn.Image = Properties.Resources.lvl3_default;    
        }
        public void level4_btn_MouseLeave(object sender, EventArgs e)
        {
            level4_btn.Image = Properties.Resources.lvl4_default;    
        }
        public void level5_btn_MouseLeave(object sender, EventArgs e)
        {
            level5_btn.Image = Properties.Resources.lvl5_default;    
        }
        public void level6_btn_MouseLeave(object sender, EventArgs e)
        {
            level6_btn.Image = Properties.Resources.lvl6_default;    
        }
        public void level7_btn_MouseLeave(object sender, EventArgs e)
        {
            level7_btn.Image = Properties.Resources.lvl7_default;    
        }
        public void level8_btn_MouseLeave(object sender, EventArgs e)
        {
            level8_btn.Image = Properties.Resources.lvl8_default;    
        }
        public void level8_btn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "short.wav";
            click.Play();
            pictureBox1.Image = Properties.Resources.soon;

        }
        public void level4_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level4 level4 = new Level4();
            level4.StartPosition = FormStartPosition.CenterScreen;
            level4.ShowDialog();
        }
        public void level1_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1();
            level1.StartPosition = FormStartPosition.CenterScreen;
            level1.ShowDialog();
        }
        public void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_menu menu = new main_menu();
            menu.ShowDialog();
        }
        public void level2_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level2 level2 = new Level2();
            level2.StartPosition = FormStartPosition.CenterScreen;
            level2.ShowDialog();
        }
        public void level3_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level3 level3 = new Level3();
            level3.StartPosition = FormStartPosition.CenterScreen;
            level3.ShowDialog();
        }
        public void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            exit_btn.Image = Properties.Resources.leftarrow_keyin;   
        }
        public void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.left_arr_default;
        }
        public void level5_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level5 level5 = new Level5();
            level5.StartPosition = FormStartPosition.CenterScreen;
            level5.ShowDialog();
        }
        public void level7_btn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "short.wav";
            click.Play();
            pictureBox1.Image = Properties.Resources.soon;
        }
        public void level6_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level6 level6 = new Level6();
            level6.StartPosition = FormStartPosition.CenterScreen;
            level6.ShowDialog();
        }
    }
}
