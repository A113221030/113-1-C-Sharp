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

            // ���n���s�ƥ�B�z�{��
            private void btnArea_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width))
                {
                    double area = length * width;
                    MessageBox.Show($"���n��: {area} ������", "�p�⵲�G");
                }
                else
                {
                    MessageBox.Show("�п�J���Ī��Ʀr�I", "��J���~");
                }
            }

            // ��ɫ��s�ƥ�B�z�{��
            private void btnBoundary_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width))
                {
                    double boundary = 2 * (length + width);
                    MessageBox.Show($"��ɪ��׬�: {boundary} ���", "�p�⵲�G");
                }
                else
                {
                    MessageBox.Show("�п�J���Ī��Ʀr�I", "��J���~");
                }
            }

            // �������s�ƥ�B�z�{��
            private void btnCost_Click(object sender, EventArgs e)
            {
                if (double.TryParse(txtLength.Text, out double length) &&
                    double.TryParse(txtWidth.Text, out double width) &&
                    double.TryParse(txtCost.Text, out double cost))
                {
                    double boundary = 2 * (length + width);
                    double totalCost = boundary * cost;
                    MessageBox.Show($"�`������: {totalCost:C}", "�p�⵲�G"); // �ϥγf���榡
                }
                else
                {
                    MessageBox.Show("�п�J���Ī��Ʀr�I", "��J���~");
                }
            }

            // �h�X���s�ƥ�B�z�{��
            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

}
}
