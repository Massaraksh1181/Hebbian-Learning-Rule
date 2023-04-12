using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OMA_lab1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "";
                int[] WFounding(string name)
                {
                    int x, y;
                    Bitmap image = new Bitmap(@name, true);
                    int width = image.Width, height = image.Height;//
                    int i = width * height;
                    int[] newClass = new int[i + 1];

                    for (y = 0, i = 1; y < image.Height; y++)
                    {
                        for (x = 0; x < image.Width; x++, i++)
                        {
                            Color pixelColor = image.GetPixel(x, y);
                            image.SetPixel(x, y, pixelColor);

                            if (pixelColor.R == 0 && pixelColor.G == 0 && pixelColor.B == 0)
                            {
                                newClass[i] = 1;
                            }
                            else newClass[i] = -1;
                        }
                    }
                    return newClass;
                }

                int[] newClass1 = WFounding(name1);
                int[] newClass2 = WFounding(name2);
                int j = newClass2.Length;

                int[] summ()
                {
                    newClass1[0] = 1;
                    newClass2[0] = 1;
                    int aa = j;
                    int[] summa = new int[j + 1];
                    for (j = 0; j < aa; j++)
                    {
                        summa[j] = newClass1[j] * 1 + newClass2[j] * -1;
                    }
                    return summa;
                }

                int test(int[] testClass, int[] summa)
                {
                    int aa = j;
                    int Summ = 0;
                    for (j = 0; j < aa; j++)
                    {
                        Summ = Summ + summa[j] * testClass[j];
                    }
                    return Summ;
                }

                if (test(newClass1, summ()) > 0 && test(newClass2, summ()) < 0)
                {
                    label2.Text = "Нейрон обучен \n";
                    int[] newClass3 = WFounding(name3);
                    if (test(newClass3, summ()) > 0)
                        label2.Text = label2.Text + "Изображение относится к первому классу \n";
                    if (test(newClass3, summ()) < 0)
                        label2.Text = label2.Text + "Изображение относится ко второму классу \n";
                }
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Вы не выбрали изображение или, возможно, выбрали фаил недопустимого формата.");
            }
        }

        string name1;
        string name2;
        string name3;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    name1 = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(@name1);
                    label2.Text = label2.Text + "\n" + name1;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Вы не выбрали изображение или, возможно, выбрали фаил недопустимого формата.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name2 = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(@name2);
                    label2.Text = label2.Text + "\n" + name2;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Вы не выбрали изображение или, возможно, выбрали фаил недопустимого формата.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name3 = openFileDialog1.FileName;
                    pictureBox3.Image = Image.FromFile(@name3);
                    label2.Text = label2.Text + "\n" + name3;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Вы не выбрали изображение или, возможно, выбрали фаил недопустимого формата.");
            }
        }
    }
}
