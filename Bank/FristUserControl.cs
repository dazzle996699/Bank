using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FristUserControl : UserControl
    {
        private int MonthPay;
        private int Ostatok;
        private int MonthPercent;
        private int MonthPayPercent;
        public FristUserControl()
        {
            InitializeComponent();
        }

        string testc;

        private void MonthPay_Click(object sender, EventArgs e)
        {
            MonthPay = Convert.ToInt32(tB_SummCred.Text) / Convert.ToInt32(tB_Mouth.Text);
            testc = "Ежемесячный платеж: " + MonthPay + "\n";
            MonthPayPercent_click(MonthPay);
        }

        private void MonthPayPercent_click(int MonthPay)
        {

            testc += "Номер месяца | " + "Остаток | " + "Ежемесячный процент | " + "Ежемесячный платеж по кредиту\n";
            for (int MonthNumber = 0; MonthNumber <= Convert.ToInt32(tB_Mouth.Text); MonthNumber++)
            {
                Ostatok = Convert.ToInt32(tB_SummCred.Text) - (MonthPay * MonthNumber);
                MonthPercent = ((Ostatok * Convert.ToInt32(tB_Proc.Text) * 31) / 365);
                MonthPayPercent = MonthPay + MonthPercent;
                testc += MonthNumber + " | "+ Ostatok + " | " + MonthPercent + " | " + MonthPayPercent + "\n";
            }

            Lb_Result.Text = testc;
        }
    }
}
