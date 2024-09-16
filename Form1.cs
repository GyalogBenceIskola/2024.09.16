using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._09._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lottoszamok = new int[90];
            for (int i = 0; i < lottoszamok.Length; i++)
            {
                lottoszamok[i] = i + 1;
            }

            int[] kivalasztottSzamok = new int[6];
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                int index = rand.Next(0, lottoszamok.Length);
                kivalasztottSzamok[i] = lottoszamok[index];

                lottoszamok[index] = lottoszamok[lottoszamok.Length - 1];
                Array.Resize(ref lottoszamok, lottoszamok.Length - 1);
            }
            label1.Text = string.Join(", ", kivalasztottSzamok);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
