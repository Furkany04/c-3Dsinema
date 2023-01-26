using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Dsinemahocayapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,,] sinema = new string[2,3,4];

        private void Form1_Load(object sender, EventArgs e)
        {
            sinema[0, 0, 0] = "X";
            sinema[0, 0, 1] = "X";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            

            int katboyut = sinema.GetLength(0);
            int salonboyut = sinema.GetLength(1);
            int secimkat = comboBox1.SelectedIndex;
            int secimsalon = comboBox2.SelectedIndex;
            
            for (int kat  = 0; kat  < katboyut; kat ++)
            {
                for (int salon = 0; salon < salonboyut; salon++)
                {
                    for (int koltuk = 0; koltuk < 4; koltuk++)
                    {
                        if (sinema[secimkat, secimsalon, koltuk] == "X")
                        {
                            switch(koltuk)
                            {
                                case 0:
                                    textBox1.Text= "X"; 
                                    textBox1.ReadOnly= true;
                                    break;
                                case 1:
                                    textBox2.Text = "X";
                                    textBox2.ReadOnly = true;
                                    break;
                                case 2:
                                    textBox3.Text = "X";
                                    textBox3.ReadOnly = true;
                                    break;
                                case 3:
                                    textBox4.Text = "X";
                                    textBox4.ReadOnly = true;
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int katno =int.Parse(comboBox1.Text);
            int salon = comboBox2.SelectedIndex;
            if(textBox1.Text == "X")
            {
                sinema[katno, salon, 0] = "X";
            }
            if (textBox2.Text == "X")
            {
                sinema[katno, salon, 1] = "X";
            }
            if (textBox3.Text == "X")
            {
                sinema[katno, salon, 2] = "X";
            }
            if (textBox4.Text == "X")
            {
                sinema[katno, salon, 3] = "X";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int katno = int.Parse(comboBox1.Text);
            int salon = comboBox2.SelectedIndex;
            if (textBox1.Text == "")
            {
                sinema[katno, salon, 0] = "";
                MessageBox.Show("bilet iptal edildi");
            }
            if (textBox2.Text == "")
            {
                sinema[katno, salon, 1] = "";
                MessageBox.Show("bilet iptal edildi");
            }
            if (textBox3.Text == "")
            {
                sinema[katno, salon, 2] = "";
                MessageBox.Show("bilet iptal edildi");
            }
            if (textBox4.Text == "")
            {
                sinema[katno, salon, 3] = "";
                MessageBox.Show("bilet iptal edildi");
            }


        }

       
        

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "X")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            if (textBox2.Text == "X")
            {
                textBox2.Clear();
            }
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            if (textBox3.Text == "X")
            {
                textBox3.Clear();
            }
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            if (textBox4.Text == "X")
            {
                textBox4.Clear();
            }
        }
    }
}
