/*----------------------------------------------------------------------------------
 * 班級:資管一乙
 * 學號:A113221030
 * 姓名:胡宇芬大美女
 *--------------------------------------------------------------------------------*/
namespace tutorial
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //顯示撲克牌背面
        private void button1_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //設定visible屬性為假

            ptxfront.Visible = false;
        }
        //顯示撲克牌正面
        private void button2_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
