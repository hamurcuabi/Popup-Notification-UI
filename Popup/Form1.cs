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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
            new BasePopup("Succes", AlertType.Succes).Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            new BasePopup("Error", AlertType.Error).Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
            new BasePopup("Warning", AlertType.Warning).Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            new BasePopup("Info", AlertType.Info).Show();

        }
    }
}
