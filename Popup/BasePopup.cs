using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popup
{
    public partial class BasePopup : Form
    {
        public BasePopup(String message, AlertType alertType)
        {
            InitializeComponent();
          
            switch (alertType)
            {
                case AlertType.Succes:

                    this.BackColor = Color.FromArgb(0, 126, 51);
                    pbType.Image = imageList1.Images[0];

                    break;
                case AlertType.Error:

                    this.BackColor = Color.FromArgb(204, 0, 0);
                    pbType.Image = imageList1.Images[2];


                    break;
                case AlertType.Warning:

                    this.BackColor = Color.FromArgb(255, 136, 0);
                    pbType.Image = imageList1.Images[1];


                    break;
                case AlertType.Info:

                    this.BackColor = Color.FromArgb(0, 153, 204);
                    pbType.Image = imageList1.Images[3];


                    break;


            }

            lblMessage.Text = message;


        }

        private void BasePopup_Load(object sender, EventArgs e)
        {
            PopupHelper.Popupcount++;
            timerFirst.Start();
            this.Top = -20 + (((PopupHelper.Popupcount % 4)) * 80);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 20;
        }

        private void TimerFirst_Tick(object sender, EventArgs e)
        {
            if (this.Top < 20 + (((PopupHelper.Popupcount % 4) ) * 80))
            {

                this.Opacity += 0.05;
                this.Top += 2;
            }
            else {
                timerFirst.Stop();
                timerThird.Start();
            }
        }

        private void TimerSecond_Tick(object sender, EventArgs e)
        {
            if (this.Top > -20 - (((PopupHelper.Popupcount%4)) * 80))
            {

                this.Opacity -= 0.05;
                this.Top -= 2;

            }
            else {
                timerSecond.Stop();
                timerThird.Stop();
                this.Close();
                

            }
        }

        private void TimerThird_Tick(object sender, EventArgs e)
        {
            timerSecond.Start();
        }

        private void Pbclose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

      
    }
}
