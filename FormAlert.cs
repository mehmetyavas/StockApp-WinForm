using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Properties;
namespace StockApp
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }
        
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum AlertType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private FormAlert.enmAction action;

        private int x, y;


        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 2500;
                    action = enmAction.close;
                    break;
                case FormAlert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = FormAlert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        this.Dispose();
                    }
                    break;
            }
        }

        private void Form_Alert_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void showAlert(string msg, AlertType type)
        {
            this.Opacity = 0;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormAlert frm = (FormAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.TopLevel = true;
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case AlertType.Success:
                    this.pictureBox1.Image = Resources.Success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.Error:
                    this.pictureBox1.Image = Resources.Warning;
                    this.BackColor = Color.DarkRed;
                    break;
                case AlertType.Info:
                    this.pictureBox1.Image = Resources.Info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Warning:
                    this.pictureBox1.Image = Resources.Warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.Show();
            this.timer1.Start();

        }
    }
}
