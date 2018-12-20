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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //byte[] masByte;
        //BigInteger[] masBI;
        Dictionary<int, byte> dictByte;
        Dictionary<int, BigInteger> dictBI;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs _e)
        {
                    dictByte = new Dictionary<int, byte>();
                    dictBI = new Dictionary<int, BigInteger>();
                    string inputFileName = tbEncodeInputFle.Text;
                    string s = "";
                    StreamReader sr = new StreamReader(inputFileName);
                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine();
                    }
                    sr.Close();
                    string outputFileName = tbEncodeOutputFle.Text;
                    byte[] fileBytes = File.ReadAllBytes(inputFileName);
                    for (int i = 0; i < fileBytes.Length; i++)
                    {
                        dictByte.Add(i, fileBytes[i]);
                        dictBI.Add(i, 0);
                    }
                    long []openKey=getKey("open");
                    encodeFile(outputFileName,openKey[0], openKey[1]);
               // }
                //catch(Exception ex){
                //    MessageBox.Show(ex.Message);
                //}      
        }

        private long[] getKey(string type)
        {
            if (type == "open")
            {
                long a = Convert.ToInt64(tb_e.Text.Remove(tb_e.Text.IndexOf('e'), 3));
                return new long[] { Convert.ToInt64(tb_e.Text.Remove(tb_e.Text.IndexOf('e'), 3)), Convert.ToInt64(tb_n_open.Text.Remove(tb_n_open.Text.IndexOf('n'), 3)) };
            }
            else
            {
                return new long[] { Convert.ToInt64(tb_d.Text.Remove(tb_d.Text.IndexOf('d'), 3)), Convert.ToInt64(tb_n_private.Text.Remove(tb_n_private.Text.IndexOf('n'), 3)) };
            }
        }

        private void encodeFile(string outputFileName, long e,long n)
        {
            EncodeRSA(e, n);
            StreamWriter sw = new StreamWriter(outputFileName);
            for (int i = 0; i < dictBI.Count; i++)
            {
                sw.WriteLine(dictBI[i] + "");
            }
            sw.Close();
            MessageBox.Show("Зашифровано");
        }

        //расшифровать

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            try {
                 
                dictByte = new Dictionary<int, byte>();
                dictBI = new Dictionary<int, BigInteger>();
                string inputFileName = tbDecodeInputFle.Text;
                string[] input = File.ReadAllLines(inputFileName);
                for (int i = 0; i < input.Length; i++)
                {
                    dictBI.Add(i, (BigInteger)Convert.ToDouble(input[i]));
                    dictByte.Add(i, 0);
                }
                string outputFileName = tbDecodeOutputFle.Text;
                long[] privateKey = getKey("private");
                decodeRSA(privateKey[0], privateKey[1]);
                byte[] masByte = new byte[dictByte.Count];
                for (int i = 0; i < dictByte.Count; i++)
                {
                    masByte[i] = dictByte[i];
                }
                    File.WriteAllBytes(outputFileName, masByte);
                MessageBox.Show("Расшифровано");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //проверка: простое ли число?

        private void isSimpleNumber(long n)

        {
            if (n < 2)
                throw new Exception(n + " - не простое число!");
            if (n == 2)
                return ;
            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    throw new Exception(n + " - не простое число!");
            return;
        }

        //зашифровать

        private void EncodeRSA(long e, long n)

        {
            BigInteger bi;
            if (dictByte.Count > 500)
            {
                for (int j = 0; j < (dictByte.Count / 500) - 1; j++)
                {
                    for (int i = j * 500; i < (j + 1) * 500; i++)
                    {
                        int index = dictByte[i];
                        bi = new BigInteger(index);
                        bi = BigInteger.Pow(bi, (int)e);
                        BigInteger n_ = new BigInteger((int)n);
                        bi = bi % n_;
                        dictBI[i] = bi;
                    }
                };
                int val = 0;
                for (int i = ((dictByte.Count / 500) - 1) * 500; i < dictByte.Count; i++)
                {
                    val++;
                    int index = dictByte[i];
                    bi = new BigInteger(index);
                    bi = BigInteger.Pow(bi, (int)e);
                    BigInteger n_ = new BigInteger((int)n);
                    bi = bi % n_;
                    dictBI[i] = bi;
                }

            }
            else

            {
                for (int i = 0; i < dictBI.Count; i++)

                {
                    int index = dictByte[i];
                    bi = new BigInteger(index);
                    bi = BigInteger.Pow(bi, (int)e);
                    BigInteger n_ = new BigInteger((int)n);
                    bi = bi % n_;
                    dictBI[i] = bi;
                }
            }
        }

        private void decodeRSA(long d, long n)
        {
            BigInteger bi;
            if (dictBI.Count > 500)
            {
                for (int j = 0; j < (dictBI.Count / 500) - 1; j++)
                {
                    for (int i = j * 500; i < (j + 1) * 500; i++)
                    {
                        bi = dictBI[i];
                        bi = BigInteger.Pow(bi, (int)d);
                        BigInteger n_ = new BigInteger((int)n);
                        bi = bi % n_;
                        int index = Convert.ToInt32(bi.ToString());
                        dictByte[i] = Convert.ToByte(index);

                    }
                };
                int val = 0;
                for (int i = ((dictBI.Count / 500) - 1) * 500; i < dictBI.Count; i++)
                {
                    val++;
                    bi = dictBI[i];
                    bi = BigInteger.Pow(bi, (int)d);
                    BigInteger n_ = new BigInteger((int)n);
                    bi = bi % n_;
                    int index = Convert.ToInt32(bi.ToString());
                    dictByte[i] = Convert.ToByte(index);
                }
            }
            else

            {
                for (int i = 0; i < dictBI.Count; i++)

                {
                    bi = dictBI[i];
                    bi = BigInteger.Pow(bi, (int)d);
                    BigInteger n_ = new BigInteger((int)n);
                    bi = bi % n_;
                    int index = Convert.ToInt32(bi.ToString());
                    dictByte[i] = Convert.ToByte(index);
                }
            }
        }

        //вычисление параметра d. d должно быть взаимно простым с m

        private long countD(long f)

        {
            long d = f - 1;
            for (long i = 2; i <= f; i++)

                if ((f % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }
            return d;
        }

        //вычисление параметра e

        private long countE(long d, long m)
        {
            long e = 1;
            while (true)
            {
                if ((e * d) % m == 1&&e!=d)
                    break;
                else
                    e++;
            }
            return e;
        }

        private void button3_Click(object sender, EventArgs _e)
        {
            try
            {
                long p = Convert.ToInt64(tb_p.Text);
                long q = Convert.ToInt64(tb_q.Text);
                isSimpleNumber(q);
                isSimpleNumber(p);
                dictByte = new Dictionary<int, byte>();
                dictBI = new Dictionary<int, BigInteger>();
                long n = p * q;
                long f = (p - 1) * (q - 1);
                long d = countD(f);
                long e = countE(d, f);
                tb_d.Text = "d: "+d;
                tb_n_open.Text = tb_n_private.Text = "n: "+n;
                tb_e.Text ="e: "+e;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Выберите файл с данными");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbEncodeInputFle.Text = openFileDialog1.FileName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Выберите файл с данными");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbEncodeOutputFle.Text = openFileDialog1.FileName;
        }

        private void tbEncodeInputFle_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = tbEncodeInputFle.Text != "" && tbEncodeOutputFle.Text != "";
        }

        private void tbEncodeOutputFle_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = tbEncodeInputFle.Text != "" && tbEncodeOutputFle.Text != "";
        }

        private void tbDecodeIntputFle_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = tbDecodeInputFle.Text != "" && tbDecodeOutputFle.Text != "";
        }

        private void tbDecodeOutputFle_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = tbDecodeInputFle.Text != "" && tbDecodeInputFle.Text != "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbDecodeInputFle.Text = openFileDialog1.FileName;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbDecodeOutputFle.Text = openFileDialog1.FileName;
        }
    }

}