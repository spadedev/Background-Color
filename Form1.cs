using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background_Color
{
    public partial class BackgroundColor : Form
    {
        public BackgroundColor()
        {
            InitializeComponent();
        }

        private void yellow_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (yellow_rb.Checked)
                this.BackColor = System.Drawing.Color.Yellow;
        }

        private void red_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (red_rb.Checked)
                this.BackColor = System.Drawing.Color.Red;
        }

        private void white_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (white_rb.Checked)
                this.BackColor = System.Drawing.Color.White;
        }

        private void btn_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_rb.Checked)
                this.BackColor = System.Drawing.Color.GhostWhite;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
