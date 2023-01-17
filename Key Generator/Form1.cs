using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_Generator
{
    public partial class Form1 : Form
    {
        string randomBox1;
        string randomBox2;
        string randomBox3;
        string randomBox4;

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void StartGenerator()
        {
            randomBox1 = RandomString(5);
            randomBox2 = RandomString(5);
            randomBox3 = RandomString(5);
            randomBox4 = RandomString(5);

            labelBox1.Text = randomBox1.ToString();
            labelBox2.Text = randomBox2.ToString();
            labelBox3.Text = randomBox3.ToString();
            labelBox4.Text = randomBox4.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            StartGenerator();
            btnGenerate.Enabled = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(labelBox1.Text + "-" + labelBox2.Text + "-" + labelBox3.Text + "-" + labelBox4.Text);
        }

        private void labelBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelBox3_Click(object sender, EventArgs e)
        {

        }

        private void labelBox4_Click(object sender, EventArgs e)
        {

        }


    }
}
