using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //определение простого числа
        private bool SimpleNumber(long num)
        {
            if (num < 2)
                return false;

            if (num == 2)
                return true;

            for (long i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        //определение примитивного корня
        private bool PrimitiveRoot(long q,long a)
        {
            List<long> primitive = new List<long>();
            for(int i = 1; i < q ; i++)
            {
                primitive.Add(i);
            }
            for (int i = 1; i < q; i++)
            {
                long temp = (long)((Math.Pow(a, i)) % q);
                if (primitive.Contains(temp))
                {
                    primitive.Remove(temp);
                }
                else
                    return false;
            }
            return true;
        }



        private void buttonDH_Click(object sender, EventArgs e)
        {
            if ((textBoxQ.Text != "") && (textBoxA.Text != "") && (textBoxYi.Text != "") && (textBoxCloseI.Text != ""))
            {
                try
                {
                    long q = Convert.ToInt64(textBoxQ.Text);
                    long a = Convert.ToInt64(textBoxA.Text);
                    long xi = Convert.ToInt64(textBoxCloseI.Text);
                    long yj = Convert.ToInt64(textBoxYi.Text);
                    long ki;


                    if (SimpleNumber(q) && (a < q))
                    {
                        if (PrimitiveRoot(q, a))
                        {
                            if (xi < q)
                            {
                                ki = (long)((Math.Pow(yj, xi)) % q);
                                textBoxK.Text = "" + ki;
                            }
                            else
                                MessageBox.Show("Закрытый ключ  >= Q");
                        }
                        else
                            MessageBox.Show("A не является примитивным корнем Q");
                    }
                    else
                    {
                        MessageBox.Show("Число Q  не простое,либо A >= Q");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите Q,A,Xi,Yj");
            }
        }

        private void buttonGeneration_Click(object sender, EventArgs e)
        {
            if ((textBoxQ.Text != "") && (textBoxA.Text != "") && (textBoxCloseJ.Text != ""))
            {
                try
                {
                    long q = Convert.ToInt64(textBoxQ.Text);
                    long a = Convert.ToInt64(textBoxA.Text);
                    long xj = Convert.ToInt64(textBoxCloseJ.Text);
                    long yj;
                    string str = "";

                    if (SimpleNumber(q) && (a < q))
                    {
                        if (PrimitiveRoot(q, a))
                        {
                            if (xj < q)
                            {
                                yj = (long)((Math.Pow(a, xj)) % q);
                                textBoxYj.Text = "" + yj;
                                MessageBox.Show("Выберите файл для записи открытого ключа");
                                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                                    return;
                                string fileWrite = saveFileDialog1.FileName;
                                StreamWriter sw = new StreamWriter(fileWrite);
                                str = textBoxQ.Text + "\r\n" + textBoxA.Text + "\r\n" + yj;
                                sw.WriteLine(str);
                                sw.Close();
                            }
                            else
                                MessageBox.Show("Закрытый ключ >= Q");
                        }
                        else
                            MessageBox.Show("A не является примитивным корнем Q");
                    }
                    else
                    {
                        MessageBox.Show("Число Q  не простое,либо A >= Q");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите Q,A,Xj");
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите файл для считывания открытого ключа и значений Q и A");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileRead = openFileDialog1.FileName;
            string[] str = File.ReadAllLines(fileRead);
            textBoxQ.Text = str[0];
            textBoxA.Text = str[1];
            textBoxYi.Text = str[2];
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Котов Д.А. ПИбд-41\n" 
                + "Алгоритм Диффи-Хеллмана");
        }

        private void обАлгоритмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель алгоритма состоит в том, чтобы два участника могли безопасно обменяться ключом, который в дальнейшем может использоваться в каком - либо алгоритме симметричного шифрования.\nСам алгоритм Диффи - Хеллмана может применяться только " + 
"для обмена ключами.\n Алгоритм основан на трудности вычислений дискретных логарифмов.Дискретный логарифм определяется следующим образом.Вводится понятие примитивного корня простого числа Q как числа, чьи степени создают все целые от 1 до Q - 1 Это означает, что " +
"если А является примитивным корнем простого числа Q, тогда числа A mod Q, A^2 mod Q, . . . , A^(Q - 1) mod Q являются различными и состоят из целых от 1 до Q - 1 с некоторыми перестановками.\n\n Предполагается, что существуют два известных всем числа: простое число Q и целое A, " +
"которое является примитивным корнем Q.Теперь предположим, что пользователи I и J хотят обменяться ключом для алгоритма симметричного шифрования.Пользователь I выбирает случайное число Хi < Q и вычисляет Yi = A^Xi mod Q.Аналогично пользователь J независимо " +
"выбирает случайное целое число Хj < Q и вычисляет Yj = A^Xj mod Q.Каждая сторона держит значение Х в секрете и делает значение Y доступным для другой стороны.Теперь пользователь I вычисляет ключ как К = (Yj)^Xi mod Q, и пользователь J вычисляет ключ как K= (Yi)^Xj mod Q. В результате оба получат одно и то же значение."+
"\n\n Таким образом, две стороны обменялись секретным ключом. Так как Хi и Хj являются закрытыми, противник может получить только следующие значения: Q, A, Yi и Yj.");
        }
        private DESCryptoServiceProvider DESCrypt;
        //шифрование
        private void button1_Click(object sender, EventArgs e)
        {
            string passPhrase = textBoxK.Text + "probaCarl";

            MessageBox.Show("Выберите файл,который требуется шифровать");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string decryptedFile = openFileDialog1.FileName;
            MessageBox.Show("Создайте файл,который будет зашифрованным");
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string encryptedFile = saveFileDialog1.FileName;

            DESCrypt = new DESCryptoServiceProvider
            {
                Mode = CipherMode.CBC,
                Key = Encoding.UTF8.GetBytes(passPhrase).Take(8).ToArray(),
                IV = Encoding.UTF8.GetBytes(passPhrase).Take(8).ToArray()
            };
            try
            {
                string tempString;
                using (var reader = new StreamReader(decryptedFile))
                {
                    tempString = reader.ReadToEnd();
                }
                FileStream fStr = File.Open(encryptedFile, FileMode.Create);
                CryptoStream cStr = new CryptoStream(fStr, new DESCryptoServiceProvider().CreateEncryptor(DESCrypt.Key, DESCrypt.IV), CryptoStreamMode.Write);
                StreamWriter strWriter = new StreamWriter(cStr);
                strWriter.WriteLine(tempString);
                strWriter.Close();
                cStr.Close();
                fStr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при записи зашифрованного файла: {0}", ex.Message);
            }
        }
        //расшифровка
        private void button2_Click(object sender, EventArgs e)
        {
            string passPhrase = textBoxK.Text + "probaCarl";

            MessageBox.Show("Выберите файл,который требуется расшифровать");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string encryptedFile = openFileDialog1.FileName;
            MessageBox.Show("Создайте файл,который будет расшифрованным");
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string decryptedFile = saveFileDialog1.FileName;

            DESCrypt = new DESCryptoServiceProvider
            {
                Mode = CipherMode.CBC,
                Key = Encoding.UTF8.GetBytes(passPhrase).Take(8).ToArray(),
                IV = Encoding.UTF8.GetBytes(passPhrase).Take(8).ToArray()
            };
            try
            {
                FileStream fStr = File.Open(encryptedFile, FileMode.OpenOrCreate);
                CryptoStream cStr = new CryptoStream(fStr, new DESCryptoServiceProvider().CreateDecryptor(DESCrypt.Key, DESCrypt.IV), CryptoStreamMode.Read);
                StreamReader strReader = new StreamReader(cStr);
                string tempString = strReader.ReadToEnd();
                strReader.Close();
                cStr.Close();
                fStr.Close();
                StreamWriter strWriter = new StreamWriter(decryptedFile);
                strWriter.WriteLine(tempString);
                strWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при открытии зашифрованного файла: {0}", ex.Message);
            }
        }

    }
}