using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private uint pom1,pom2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label24.Visible = true;

            label3.Text = "Trougao";
            label3.Visible = true;
            label6.Visible = false;
            label32.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            panel1.Visible = false;
            panel1.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            label9.Visible = false;
            label10.Visible = false;
        }

       

        private void label9_Click_1(object sender, EventArgs e)
        {
            label32.Visible = true;
            label33.Visible = false;
            label34.Visible = false;
            
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;

            label8.Visible = false;
            label10.Visible = false;

            
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label9.Visible == true)
                {
                    Trougao noviTrougao = new JednakostranicniTrougao(Convert.ToUInt32(textBox1.Text));

                    label3.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    panel2.Visible = false;
                    panel1.Visible = true;

                    Graphics gObject = panel1.CreateGraphics();

                    Brush crno = new SolidBrush(Color.Black);
                    Pen crnaOlovka = new Pen(crno, 2);

                    gObject.Clear(Color.White);
                    gObject.DrawLine(crnaOlovka, 30, 400, Convert.ToInt32(textBox1.Text) + 30, 400);
                    gObject.DrawLine(crnaOlovka, 30, 400, Convert.ToInt32(textBox1.Text) / 2 + 30, 400 - Convert.ToInt32(textBox1.Text));
                    gObject.DrawLine(crnaOlovka, 30 + Convert.ToInt32(textBox1.Text), 400, Convert.ToInt32(textBox1.Text) / 2 + 30, 400 - Convert.ToInt32(textBox1.Text));

                    label27.Text = Convert.ToString(noviTrougao.obim.ToString("0.00"));
                    label28.Text = Convert.ToString(noviTrougao.povrsina.ToString("0.00"));
                    label29.Text = Convert.ToString(noviTrougao.h.ToString("0.00"));
                    label3.Text = noviTrougao.tipFigure;
                    label30.Text = Convert.ToString(noviTrougao.R.ToString("0.00"));
                    label31.Text = Convert.ToString(noviTrougao.r.ToString("0.00"));
                    
                }
                else if (label8.Visible == true)
                {
                    pom1 = Convert.ToUInt32(textBox1.Text);
                    textBox2.Focus();
                }
                else if (label10.Visible == true)
                {
                    pom1 = Convert.ToUInt32(textBox1.Text);
                    textBox2.Focus();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;

            label9.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
            label17.Visible = true;
            label6.Visible = true;

            label3.Text = "Cetvorougao";
            label3.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label24.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            panel1.Visible = false;
            panel1.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label35.Visible = true;
            textBox4.Visible = true;

            label16.Visible = false;
            label36.Visible = false;
            textBox5.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label35.Visible = true;
            label36.Visible = true;

            textBox4.Visible = true;
            textBox5.Visible = true;

            label17.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label35.Visible = true;

            textBox4.Visible = true;

            label16.Visible = false;
            label17.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

            label16.Visible = false;
            label17.Visible = false;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label17.Visible == true)
                {
                    Cetvorougao noviCetvorougao = new Kvadrat(Convert.ToUInt32(textBox4.Text));

                    label3.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label6.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    panel2.Visible = false;
                    panel1.Visible = true;
                    
                    Graphics gObject = panel1.CreateGraphics();

                    Brush crno = new SolidBrush(Color.Black);
                    Pen crnaOlovka = new Pen(crno, 2);

                    gObject.Clear(Color.White);
                    gObject.DrawRectangle(crnaOlovka, 50, 30, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox4.Text));

                    label27.Text = Convert.ToString(noviCetvorougao.obim.ToString("0.00"));
                    label29.Text = Convert.ToString(noviCetvorougao.d.ToString("0.00"));
                    label28.Text = Convert.ToString(noviCetvorougao.povrsina.ToString("0.00"));
                    label3.Text = noviCetvorougao.tipFigure;
                    label30.Text = Convert.ToString(noviCetvorougao.R.ToString("0.00"));
                    label31.Text = Convert.ToString(noviCetvorougao.r.ToString("0.00"));
                }
                else if (label16.Visible == true)
                {
                    pom1 = Convert.ToUInt32(textBox4.Text);
                    textBox5.Focus();
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label16.Visible == true)
                {
                    Cetvorougao noviCetvorougao = new Pravougaonik(pom1, Convert.ToUInt32(textBox5.Text));

                    label3.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label6.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    panel2.Visible = false;
                    panel1.Visible = true;

                    Graphics gObject = panel1.CreateGraphics();

                    Brush crno = new SolidBrush(Color.Black);
                    Pen crnaOlovka = new Pen(crno, 2);

                    gObject.Clear(Color.White);
                    gObject.DrawRectangle(crnaOlovka, 50, 30, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));

                    label27.Text = Convert.ToString(noviCetvorougao.obim.ToString("0.00"));
                    label29.Text = Convert.ToString(noviCetvorougao.d.ToString("0.00"));
                    label28.Text = Convert.ToString(noviCetvorougao.povrsina.ToString("0.00"));
                    label3.Text = noviCetvorougao.tipFigure;
                    label30.Text = Convert.ToString(noviCetvorougao.R.ToString("0.00"));
                    label31.Text = Convert.ToString(noviCetvorougao.r.ToString("0.00"));
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label8.Visible == true)
                {
                    pom2 = Convert.ToUInt32(textBox2.Text);
                    textBox3.Focus();
                }
                else if (label10.Visible == true)
                    {
                        Trougao noviTrougao = new JednakokrakiTrougao(pom1, Convert.ToUInt32(textBox2.Text));

                        label3.Visible = true;
                        label22.Visible = true;
                        label23.Visible = true;
                        label24.Visible = true;
                        label25.Visible = true;
                        label26.Visible = true;
                        label27.Visible = true;
                        label28.Visible = true;
                        label29.Visible = true;
                        label30.Visible = true;
                        label31.Visible = true;
                        panel2.Visible = false;
                        panel1.Visible = true;

                        Graphics gObject = panel1.CreateGraphics();

                        Brush crno = new SolidBrush(Color.Black);
                        Pen crnaOlovka = new Pen(crno, 2);

                        gObject.Clear(Color.White);
                        gObject.DrawLine(crnaOlovka, 30, 400, Convert.ToInt32(textBox1.Text) + 30, 400);
                        gObject.DrawLine(crnaOlovka, 30, 400, Convert.ToInt32(textBox1.Text) / 2 + 30, 400 - Convert.ToInt32(textBox2.Text));
                        gObject.DrawLine(crnaOlovka, 30 + Convert.ToInt32(textBox1.Text), 400, Convert.ToInt32(textBox1.Text) / 2 + 30, 400 - Convert.ToInt32(textBox2.Text));


                        label27.Text = Convert.ToString(noviTrougao.obim.ToString("0.00"));
                        label29.Text = Convert.ToString(noviTrougao.h.ToString("0.00"));
                        label28.Text = Convert.ToString(noviTrougao.povrsina.ToString("0.00"));
                        label3.Text = noviTrougao.tipFigure;
                        label30.Text = Convert.ToString(noviTrougao.R.ToString("0.00"));
                        label31.Text = Convert.ToString(noviTrougao.r.ToString("0.00"));


                    }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label8.Visible == true)
                {
                    Trougao noviTrougao = new PravougliTrougao(pom1, pom2, Convert.ToUInt32(textBox3.Text));

                    label3.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    panel2.Visible = false;
                    panel1.Visible = true;

                    Graphics gObject = panel1.CreateGraphics();

                    Brush crno = new SolidBrush(Color.Black);
                    Pen crnaOlovka = new Pen(crno, 2);

                    gObject.Clear(Color.White);
                    gObject.DrawLine(crnaOlovka, 30, 400, 30, 400 - Convert.ToInt32(textBox1.Text));
                    gObject.DrawLine(crnaOlovka, 30, 400, Convert.ToInt32(textBox2.Text) + 30, 400);
                    gObject.DrawLine(crnaOlovka, 30 + Convert.ToInt32(textBox2.Text), 400, 30 , 400 - Convert.ToInt32(textBox1.Text));

                    label27.Text = Convert.ToString(noviTrougao.obim.ToString("0.00"));
                    label28.Text = Convert.ToString(noviTrougao.povrsina.ToString("0.00"));
                    label29.Text = Convert.ToString(noviTrougao.h.ToString("0.00"));
                    label3.Text = noviTrougao.tipFigure;
                    label30.Text = Convert.ToString(noviTrougao.R.ToString("0.00"));
                    label31.Text = Convert.ToString(noviTrougao.r.ToString("0.00"));
                }
            }
        }
    }
}