using System;
using System.Windows.Forms;

namespace MoneyConverterApp
{
    public partial class Form1 : Form
    {
        // курсы валют
        private double usdRate = 2.5;
        private double euroRate = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // получить значение, кот. пользователь ввел в строку
            string moneyStr = this.txtBInput.Text;
            MessageBox.Show(moneyStr); // посмотреть, что в money

            double money = double.Parse(moneyStr);

            double usd = money / this.usdRate;
            double euro = money / this.euroRate;

            string convertion = $"Ваши {moneyStr} BYN составляют: \r\n{usd} USD\r\nили\r\n{euro} Euro";

            this.txtBOutput.Text = convertion;
        }
    }
}
