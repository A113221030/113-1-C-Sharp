using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入

            //以下作答
            try
            {
                income = decimal.Parse(incomeTextBox.Text); // 從 TextBox 讀取收入
                taxrate = 0.10m; // 假設稅率為 10%
                payable = income * taxrate; // 計算應交稅額
                netIncome = income - payable; // 計算淨收入

                payableLabel.Text = payable.ToString("C"); // 將結果顯示於標籤
                netIncomeLabel.Text = netIncome.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的收入數字。");
            }



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
