namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;

namespace CreditCardPointsCalculator
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnCalculatePoints_Click(object sender, EventArgs e)
            {
                try
                {
                    // ���o�ϥΪ̿�J���ʶR���B
                    decimal purchaseAmount = decimal.Parse(txtPurchaseAmount.Text);
                    int points = CalculatePoints(purchaseAmount);

                    // ��ܱ¤����n����
                    lblPoints.Text = $"Points Awarded: {points}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("�п�J���Ī����B", "��J���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // �p��n�������
            private int CalculatePoints(decimal amount)
            {
                if (amount <= 100)
                    return 1;
                else if (amount <= 500)
                    return 5;
                else if (amount <= 1000)
                    return 10;
                else if (amount <= 2000)
                    return 15;
                else
                    return 20;
            }
        }
    }

}
    }
}
