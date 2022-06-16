using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CommandFileDownloadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {

                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo("CmdUrlDownload.exe ",textBox1.Text + " " + textBox2.Text)
                };
                
                process.Start();
               
               
                
            }
            else
            {

                MessageBox.Show("Cannot Launch app");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = saveFileDialog1.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog1.FileName.ToString();

            }
            else { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
