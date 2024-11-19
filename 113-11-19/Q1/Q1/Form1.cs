namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }

        private void btnBoundary_Click(object sender, EventArgs e)
        {

        }

        private void btnCost_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }namespace Q1
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            // 面積按鈕事件處理程式
            private void btnArea_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width))
                {
                    double area = length * width;
                    MessageBox.Show($"面積為: {area} 平方單位", "計算結果");
                }
                else
                {
                    MessageBox.Show("請輸入有效的數字！", "輸入錯誤");
                }
            }

            // 邊界按鈕事件處理程式
            private void btnBoundary_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width))
                {
                    double boundary = 2 * (length + width);
                    MessageBox.Show($"邊界長度為: {boundary} 單位", "計算結果");
                }
                else
                {
                    MessageBox.Show("請輸入有效的數字！", "輸入錯誤");
                }
            }

            // 成本按鈕事件處理程式
            private void btnCost_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width) &&
                    double.TryParse(txtCost.Text, out double cost))
                {
                    double boundary = 2 * (length + width);
                    double totalCost = boundary * cost;
                    MessageBox.Show($"總成本為: {totalCost:C}", "計算結果"); // 使用貨幣格式
                }
                else
                {
                    MessageBox.Show("請輸入有效的數字！", "輸入錯誤");
                }
            }

            // 退出按鈕事件處理程式
            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

}
}
