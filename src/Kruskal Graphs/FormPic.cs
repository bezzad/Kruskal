using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Kruskal_Graphs
{
    public partial class FormPic : Form
    {
        public FormPic()
        {
            InitializeComponent();
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (prbUp.Value >= 99)
            {
                timerPic.Enabled = false;
                Thread.Sleep(100);
                Dispose();
            }
            else
            {
                switch (prbUp.Value.ToString())
                {
                    case "10":
                        {
                            lblK.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "20":
                        {
                            lblR.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "30":
                        {
                            lblU.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "40":
                        {
                            lblS.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "50":
                        {
                            lblK2.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "60":
                        {
                            lblA.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "70":
                        {
                            lblL.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                    case "80":
                        {
                            lblGraphs.Visible = true;
                            Thread.Sleep(30);
                        }
                        break;
                }
                prbDown.Value++;
                prbUp.Value++;
            }
        }

        private void FormPic_Load(object sender, EventArgs e)
        {
            timerPic.Enabled = true;
        }

    }
}
