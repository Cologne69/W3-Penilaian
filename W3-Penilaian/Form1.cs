using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3_Penilaian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Color warnaDefault = Color.Black;
        private void btn_proses_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Substring(0, 4).ToLower() == "isi:")
                {
                    lbl_text.Text = textBox1.Text.Substring(4);
                }
                else if (textBox1.Text.ToLower() == "hide")
                {
                    lbl_text.Visible = false;
                }
                else if (textBox1.Text.ToLower() == "shown")
                {
                    lbl_text.Visible = true;
                }
                else if (textBox1.Text.ToLower() == "besarkan")
                {
                    lbl_text.Font = new Font("Microsoft YaHei", lbl_text.Font.Size + 1, FontStyle.Bold);
                }
                else if (textBox1.Text.ToLower() == "kecilkan")
                {
                    lbl_text.Font = new Font("Microsoft YaHei", lbl_text.Font.Size - 1, FontStyle.Bold);
                }
                else if (textBox1.Text.ToLower() == "restart")
                {
                    lbl_text.ForeColor = warnaDefault;
                    lbl_text.Visible = true;
                    lbl_text.Font = new Font("Microsoft YaHei", 15, FontStyle.Bold);
                    lbl_text.Text = "[EMPTY]";

                }

                else if (textBox1.Text.Substring(0, 6).ToLower() == "warna:")
                {
                    if (textBox1.Text.Substring(6).ToLower() == "biru")
                    {
                        lbl_text.ForeColor = Color.Blue;

                    }
                    else if (textBox1.Text.Substring(6).ToLower() == "merah")
                    {
                        lbl_text.ForeColor = Color.Red;

                    }
                    else if (textBox1.Text.Substring(6) == "default" || textBox1.Text.Substring(6) == "hitam")
                    {
                        lbl_text.ForeColor = warnaDefault;

                    }
                    else if (textBox1.Text.Substring(6).ToLower() == "hijau")
                    {
                        lbl_text.ForeColor = Color.Green;

                    }
                    else
                    {
                        MessageBox.Show("Syntax tidak terdaftar");
                    }

                }
                else
                {
                    MessageBox.Show("Syntax tidak terdaftar");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_proses.PerformClick();



            }
        }
    }
}
