using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverterApp
{
    public partial class Form1 : Form
    {
        private double usd = 2.5;
        private double euro = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // получить значение, кот. пользователь ввел в строку
           string money = this.txtBInput.Text;
           MessageBox.Show(money); // посмотреть, что в money


        }
    }
}
