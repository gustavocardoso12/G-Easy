using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100){
                progressBar1.Value = progressBar1.Value + 1;
                label4.Text = progressBar1.Value.ToString() + "%";
                if (progressBar1.Value > 25)
                {
                    label6.Visible = true;
                    label5.Visible = false;
                    label4.Visible = true;
                    if (progressBar1.Value > 50)
                    {
                        label6.Visible = false;
                        label7.Visible =true;
                        label4.Visible = true;
                    }
                    if (progressBar1.Value > 90)
                    {
                        pictureBox2.BringToFront();
                        if (progressBar1.Value > 99)
                        {
                            pictureBox2.SendToBack();
                        }
                    }
                }
              
            }
            else{
                timer1.Enabled = false;

                MiniPaint51 MI = new MiniPaint51();
                MI.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
