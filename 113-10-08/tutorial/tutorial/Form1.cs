/*----------------------------------------------------------------------------------
 * �Z��:��ޤ@�A
 * �Ǹ�:A113221030
 * �m�W:�J�t��j���k
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
        //��ܼ��J�P�I��
        private void button1_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //�]�wvisible�ݩʬ���

            ptxfront.Visible = false;
        }
        //��ܼ��J�P����
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
