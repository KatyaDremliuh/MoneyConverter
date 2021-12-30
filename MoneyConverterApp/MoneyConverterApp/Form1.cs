using System;
using System.Windows.Forms;

namespace MoneyConverterApp
{
    public partial class Form1 : Form
    {
        // курсы валют
        private double usdRate = RateGetter.GetUsd();
        private double euroRate = 2.8545;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // получить значение, кот. пользователь ввел в строку
            string moneyStr = this.txtBInput.Text;
            //MessageBox.Show(moneyStr); // посмотреть, что в money

            double money = double.Parse(moneyStr);

            string convertion = string.Empty;
            double usd;
            double euro;
            double byn;

            if (rdBtnBYN.Checked)
            {
                usd = money / this.usdRate;
                euro = money / this.euroRate;

                convertion = $"Ваши {moneyStr} BYN составляют: \r\n{usd} USD\r\nили\r\n{euro} Euro";
            }

            if (rdBtnUSD.Checked)
            {
                byn = money * this.usdRate;
                euro = byn / this.euroRate;

                convertion = $"Ваши {moneyStr} USD составляют: \r\n{byn} BYN\r\nили\r\n{euro} Euro";
            }

            if (rdBtnEuro.Checked)
            {
                byn = money * this.euroRate;
                usd = money / 1.3;

                convertion = $"Ваши {moneyStr} Euro составляют: \r\n{byn} BYN\r\nили\r\n{usd} USD";
            }

            this.txtBOutput.Text = convertion;
        }
    }
}
