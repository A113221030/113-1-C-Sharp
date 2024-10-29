using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 解析輸入
                double test1 = double.Parse(test1TextBox.Text);
                double test2 = double.Parse(test2TextBox.Text);
                double test3 = double.Parse(test3TextBox.Text);

                // 驗證分數是否在範圍內
                if ((test1 >= 0 && test1 < 100) &&
                    (test2 >= 0 && test2 < 100) &&
                    (test3 >= 0 && test3 < 100))
                {
                    // 計算平均分數
                    double average = (test1 + test2 + test3) / 3.0;
                    averageLabel.Text = average.ToString("n1");

                    // 判斷成績
                    string grade;
                    if (average >= 90)
                    {
                        grade = "A";
                    }
                    else if (average >= 80)
                    {
                        grade = "B";
                    }
                    else if (average >= 70)
                    {
                        grade = "C";
                    }
                    else if (average >= 60)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }

                    // 顯示成績
                    MessageBox.Show("你的成績是: " + grade);
                }
                else
                {
                    MessageBox.Show("請輸入有效的分數範圍 (0-99)");
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
            // 清除輸入框和平均分數標籤
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將焦點設回 test1TextBox
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
            // 此處可處理 TextBox 的變更事件（若需要）
        }

    }
