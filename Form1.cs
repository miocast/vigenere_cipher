using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        int num, d, j, f;
        int t = 0;
        string s;

        char[] alphabet = { 
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 
            'ж', 'з', 'и', 'й', 'к', 'л', 'м', 
            'н', 'о', 'п', 'р', 'с', 'т', 'у', 
            'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 
            'ы', 'ь', 'э', 'ю', 'я' };


        //шифратор
        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            string k = textBox3.Text;

            char[] message = m.ToCharArray();
            char[] key = k.ToCharArray();


            for (int i = 0; i < message.Length; i++)
            {
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    num = j;

                    if (t > key.Length - 1)
                    {
                        t = 0;
                    }

                    for (f = 0; f < alphabet.Length; f++)
                    {
                        if (key[t] == alphabet[f])
                        {
                            break;
                        }
                    }

                    t++;

                    if (f != 33)
                    {
                        d = num + f;
                    }
                    else
                    {
                        d = num;
                    }

                    if (d > 32)
                    {
                        d = d - 33; 
                    }

                    message[i] = alphabet[d];
                }
            }

            s = new string(message);
            textBox2.Text = s;
        }

    
     

        //дешифратор
        private void button2_Click(object sender, EventArgs e)
        {
            string m = textBox2.Text;
            string k = textBox3.Text;

            char[] message = m.ToCharArray();
            char[] key = k.ToCharArray();


            for (int i = 0; i < message.Length; i++)
            {
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    d = j;

                    if (t > key.Length - 1)
                    {
                        t = 0;
                    }

                    for (f = 0; f < alphabet.Length; f++)
                    {
                        if (key[t] == alphabet[f])
                        {
                            break;
                        }
                    }

                    t++;

                    if (f != 33)
                    {
                        num = (d - f);
                    }
                    else
                    {
                      num = d;
                    }

                    if (num > 32)
                    {
                        num = num - 33;
                    }

                    message[i] = alphabet[num];
                }
            }

            s = new string(message);
            textBox1.Text = s;
        }
    }
}
