using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zam_Programı
{
    public partial class Form1 : Form
    {
                
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(1,400);
            int y = r.Next(1, 400);
            button1.Location = new Point(x, y);

            int butX = button1.Size.Width;
            int butY = button1.Size.Height;

            butX = butX - 5;
            butY = butX - 5;
            button1.Size = new System.Drawing.Size(butX, butY);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            MessageBox.Show("En iyi çalışan sizsiniz!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = false;
            button1.BackColor = Color.Yellow;
            button2.Enabled = false;
            button2.BackColor = Color.Yellow;
        }
    }
}
