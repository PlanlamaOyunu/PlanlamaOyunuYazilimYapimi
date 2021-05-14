using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PlanlamaOyunuYazilimYapimi.Functions
{
    class TextBoxKisitlama
    {
        public void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox txtB = sender as TextBox;
            if (txtB.Text.Trim() == "0")
            {
                txtB.Text = "";
            }
        }
        public void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox txtB = sender as TextBox;
            if (txtB.Text.Trim() == "")
            {
                txtB.Text = "0";
            }
        }
        public void onlyFloatValue(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyChar == 44 && tb.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}

