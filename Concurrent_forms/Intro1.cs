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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 poziomy = new Level1();
            poziomy.ShowDialog();
        }

        public void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox3.Image = Properties.Resources.rightarrow_keyin;   
        }

        public void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.right_arr_default;
        }
    }
}
