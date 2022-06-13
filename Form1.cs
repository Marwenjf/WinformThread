using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace winformThread
{
    public partial class Form1 : Form
    {
        private int[] liste= new int[500000];
        private Random random = new Random((int)DateTime.Now.Ticks);
        private bool termine = true;
        public Form1()
        {
            InitializeComponent();
            start.Click += start_Click;
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = random.Next(60000);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (termine)
            {
                Thread t = new Thread(Traitement);
                termine=false;
                t.Start();
            }
        }

        private void Traitement()
        {
            int total=0;
            for (int i = 0; i < liste.Length; i++)
            {
                if (liste[i] < 500)
                {
                    ++total;
                    int v = (int)(i/(double)liste.Length*100);
                    //progressBar.Value=v;
                    Invoke(new Action<int>(Progress),v);
                }
            }
            //result.Text = total.ToString();
            Invoke(new Action<int>(Result),total);
        }

        private void Result(int total)
        {
            result.Text = total.ToString();
            termine = true;
        }

        private void Progress(int v)
        {
            progressBar.Value=v;
            evolution.Text = v.ToString();
        }
    }
}
