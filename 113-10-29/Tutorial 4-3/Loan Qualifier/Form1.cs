using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            decimal salary;
            int years;
            const decimal MIN_SALARY = 1300000M;
            const int MIN_YEARS = 2;

            try
            {
                // 解析輸入
                salary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                // 條件判斷
                if (salary < MIN_SALARY)
                {
                    decisionLabel.Text = "薪資所得未達標準,貸款不通過";
                }
                else if (years < MIN_YEARS)
                {
                    decisionLabel.Text = "工作年資未達標準,貸款不通過";
                }
                else
                {
                    decisionLabel.Text = "條件符合,貸款通過";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字格式。");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
