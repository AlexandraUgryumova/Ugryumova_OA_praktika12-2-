using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_ОА_практика_12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Date_time d1 = new Date_time();

            if(textBox1.Text == "изменить время")
            {
                label2.Text = "нужно ли более конкретное время?";
                d1.Maketime();
            }
            else
            {
                if (textBox1.Text == "установить время")
                {
                    label2.Text = "напишите время";
                    d1.Instaltime();
                }
                else
                {
                    if (textBox1.Text == "вычислить время")
                    {
                        d1.Arithmetictime();
                    }
                    else
                    {
                        label1.Text = "команда не распознана";
                    }
                }
            }
        }
    }
    public class Date_time
    {
        public DateTime dt = DateTime.Now;
        public DateTime Instaltime()
        {
            
            return dt;
        }
        public DateTime Maketime()
        {
            return dt;
        }
        public DateTime Arithmetictime()
        {
            return dt;
        }
    }
}
