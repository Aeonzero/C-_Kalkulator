using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        String jadi;
        static string d,f,c;
        int a, b,hasil;
        int counter=0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            b = 1;
            textBox1.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text ="";
            b = 2;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text ="";
            b = 3;
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text ="";
            b = 4;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b == 1) {
                hasil = a + int.Parse(textBox1.Text);
                jadi = System.Convert.ToString(hasil);
                textBox1.Text = jadi;
            }
            else if (b == 2)
            {
                hasil = a - int.Parse(textBox1.Text);
                jadi = System.Convert.ToString(hasil);
                textBox1.Text = jadi;
            }
            else if (b == 3)
            {
                hasil = a * int.Parse(textBox1.Text);
                jadi = System.Convert.ToString(hasil);
                textBox1.Text = jadi;
            }
            else if (b == 4)
            {
                hasil = a / int.Parse(textBox1.Text);
                jadi = System.Convert.ToString(hasil);
                textBox1.Text = jadi;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int textlength = textBox1.Text.Length;
            if (textlength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textlength - 1);
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
             // for(counter=0;counter<8000;counter++)
            //{
               
                d = label1.Text;
                f = d.Substring(0, 4);
                c = d.Substring(4, d.Length - 4);
                label1.Text = c + f;
                counter++;
                if (counter >= 20)
                {
                    timer1.Stop();
                  
                }

            //}
              //   timer1.Enabled = false;
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           timer1.Interval = 1000;
           timer1.Start();
            timer1.Enabled = true;
          

            
               
                
           
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           /* int counter = 0;
            if (counter < 20)
            {
                counter++;
                while (counter == 20) {
                    timer1.Enabled = false;
                }
            }
            else
            {
                
            }*/
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          //  while (counter < 20000) {
            //    counter++;
           // }
            //timer1.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

