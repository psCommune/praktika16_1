using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string Check(string text)
        {
            if (text != "")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsDigit(text[i]))
                    {
                        return "-";
                    }
                }
            }
            else
            {
                return "-";
            }
            return "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            if (string.IsNullOrEmpty(textBox1.Text) != true)
            {
                label2.Visible = true;
                if (double.TryParse(textBox1.Text, out num))
                {
                    MessageBox.Show("нельзя вводить цифры", "Ошибка");
                }
                else
                {
                    int countRepetition = 0;
                    string fileValue;
                    string valueTwo;
                    StreamReader sr = new StreamReader("Zadan1.txt");
                    fileValue = sr.ReadLine();
                    sr.Close();
                    if (Check(fileValue) == "+" && Check(textBox1.Text) == "+")
                    {
                        fileValue.Replace('.', ',');
                        valueTwo = fileValue.ToLower();
                        string[] arr = valueTwo.Split(' ');
                        var str = arr.Where(x => textBox1.Text.ToLower() == x);
                        foreach (var p in str)
                        {
                            countRepetition++;
                        }
                        label2.Text = $"Слово встречается {countRepetition} раз";
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] mass = new string[richTextBox1.TextLength];

            //double num = 0.0;
            //int checkSymbol = 0;
            //for (int i = 0; i < mass.Length; i++)
            //if (double.TryParse(mass[i], out num))
            //{
            //        checkSymbol++;
            //}
        }
    }
}
