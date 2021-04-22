using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Concurrent_forms
{
    public partial class main_menu : Form
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public main_menu()
        {
            InitializeComponent();
            player.URL = "background_song.wav";
            player.controls.play();
            player.settings.volume = 25;
            player.settings.playCount = 3;
        }
        public void newgame_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Intro intro1 = new Intro();
            intro1.StartPosition = FormStartPosition.CenterScreen;
            intro1.ShowDialog();
        }
        public void newgame_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            newgame_btn.Image = Properties.Resources.newgame_keyin;   

        }
        public void levels_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            levels_btn.Image = Properties.Resources.lvl_sel_keyin;   
        }
        public void Exit_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            exit_btn.Image = Properties.Resources.exit_keyin;   
        }
        public void newgame_btn_MouseLeave(object sender, EventArgs e)
        {
            newgame_btn.Image = Properties.Resources.newgame_default;    
        }
        public void levels_btn_MouseLeave(object sender, EventArgs e)
        {
            levels_btn.Image = Properties.Resources.lvl_sel_default;    
        }
        public void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.exit_default;    
        }
        public void levels_btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Levels poziomy = new Levels();
            poziomy.StartPosition = FormStartPosition.CenterScreen;
            poziomy.ShowDialog();
        }
        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void options_btn_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            options_btn.Image = Properties.Resources.options_keyin;   
        }
        public void options_btn_MouseLeave(object sender, EventArgs e)
        {
            options_btn.Image = Properties.Resources.options_default;    
        }
        public void options_btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Options opcje = new Options();
            opcje.StartPosition = FormStartPosition.CenterScreen;
            opcje.ShowDialog();
            
        }
    }
}

