namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디") // 텍스트가 "아이디"인 경우에만 초기화
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) // 텍스트가 비어있거나 공백인 경우에만 초기화
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드") // 텍스트가 "패스워드"인 경우에만 초기화
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text)) // 텍스트가 비어있거나 공백인 경우에만 초기화
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;

            }
        }

        string myID = "admin";
        string myPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            if(inputID == myID && inputPW == myPW) // 입력된 아이디와 패스워드가 저장된 아이디와 패스워드와 일치하는지 확인
            {
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("로그인 실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}