using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        //Pendeklarasian
        private Stopwatch waktu = null;

        //Function
        static String Keluar(String Selesai)
        {
            return (Selesai);
        }

        //Constructor
        public String nama = "ALVIN ALVRAHESTA";
        public String id = "21120118120025";

        public String pengenalan() 
        {
            return "Nama \t\t: " + nama + "\nNIM saya \t: " + id;
        }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pengkondisian
            int a = textBox1.TextLength;

            if (a < 6)
            {
                MessageBox.Show("Nama Anda Harus Diisi Minimal 6 Karakter!!!", "Maaf");
            }

            else
            {
                waktu = new Stopwatch();
                if (button1.Text == "START")
                {
                    if (radioButton1.Checked)
                    {
                        label2.Text = "Paket 1 Jam";
                    }
                    else if (radioButton2.Checked)
                    {
                        label2.Text = "Paket 2 Jam";
                    }
                    waktu.Start();
                    textBox2.Clear();
                    button1.Text = "STOP";
                }
                else if (button1.Text == "STOP")
                {
                    if (radioButton1.Checked)
                    {
                        textBox2.Text = "Rp 3.000.";
                    }
                    if (radioButton2.Checked)
                    {
                        textBox2.Text = "Rp 7.000.";
                    }

                    waktu.Stop();
                    waktu.Reset();
                    label2.Text = "Waktu";
                    button1.Text = "START";

                    //Pemanggilan Function
                    MessageBox.Show(Keluar("BILLING Username " + textBox1.Text + " Telah Selesai."), "HALO");
                    textBox1.Text = null;

                    //Pemanggilan Constructor
                    MessageBox.Show(pengenalan(), "PROGRAM DIBUAT OLEH");
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (waktu != null)
            {
                label1.Text = waktu.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }
    }
}