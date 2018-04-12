using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Run
{
    public partial class FrmRun : Form
    {
        public FrmRun()
        {
            InitializeComponent();
        }

        Thread hiloCarro01;
        Thread hiloCarro02;
        Thread hiloCarro03;

        Int32 iPosicion = 0;

        private void btnRun_Click(object sender, EventArgs e)
        {
            hiloCarro01 = new Thread(new ThreadStart(this.RunCarro01));
            hiloCarro01.Start();

            hiloCarro02 = new Thread(new ThreadStart(this.RunCarro02));
            hiloCarro02.Start();

            hiloCarro03 = new Thread(new ThreadStart(this.RunCarro03));
            hiloCarro03.Start();
        }

        public void RunCarro01()
        {
            while (picCarro01.Left <= 950)
            {
                Random _random = new Random();
                int x = _random.Next(0, 10);

                this.Invoke((MethodInvoker)delegate
                {
                    this.picCarro01.Left += x;
                });

                Thread.Sleep(50);
            }

            this.Invoke((MethodInvoker)delegate
            {
                iPosicion += 1;
                lblPosicion01.Text = iPosicion.ToString();
                this.picCarro01.Left = 950;
            });

            hiloCarro01.Abort();
        }

        public void RunCarro02()
        {
            while (picCarro02.Left <= 950)
            {
                Random _random = new Random();
                int x = _random.Next(0, 10);

                this.Invoke((MethodInvoker)delegate
                {
                    this.picCarro02.Left += x;
                });

                Thread.Sleep(50);
            }

            this.Invoke((MethodInvoker)delegate
            {
                iPosicion += 1;
                lblPosicion02.Text = iPosicion.ToString();
                this.picCarro02.Left = 950;
            });

            hiloCarro02.Abort();
        }

        public void RunCarro03()
        {
            while (picCarro03.Left <= 950)
            {
                Random _random = new Random();
                int x = _random.Next(0, 10);

                this.Invoke((MethodInvoker)delegate
                {
                    this.picCarro03.Left += x;
                });

                Thread.Sleep(50);
            }

            this.Invoke((MethodInvoker)delegate
            {
                iPosicion += 1;
                lblPosicion03.Text = iPosicion.ToString();
                this.picCarro03.Left = 950;
            });

            hiloCarro03.Abort();
        }
    }
}
