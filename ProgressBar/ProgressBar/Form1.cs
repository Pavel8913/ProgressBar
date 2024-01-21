using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            replaid(i);
                            this.Text = $"{i}%";
                        }));
                        Thread.Sleep(50);
                    }
                    catch
                    {
                        return;
                    }
                   


                }
            });

            //MessageBox.Show("Готово!");
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void replaid(int i)
        {
            //перезагрузка прогресс бара код из видео
            if(i==progressBar1.Maximum)
            {
                progressBar1.Maximum = i+1;
                progressBar1.Value = i + 1;
                progressBar1.Maximum = i;

            }
            else
            {
               progressBar1.Value = i +1;
            }
            progressBar1.Value = i;
        }
    }
}
