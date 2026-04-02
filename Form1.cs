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
                txtID.Text = ""; // 텍스트를 빈 문자열로 초기화
                txtID.ForeColor = Color.Black; // 텍스트 색상을 검정색으로 변경
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) // 텍스트가 비어있거나 공백인 경우에만 초기화
            {
                txtID.Text = "아이디"; // 텍스트를 "아이디"로 초기화
                txtID.ForeColor = Color.Silver; // 텍스트 색상을 은색으로 변경
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드") // 텍스트가 "패스워드"인 경우에만 초기화
            {
                txtPW.Text = ""; // 텍스트를 빈 문자열로 초기화
                txtPW.ForeColor = Color.Black; // 텍스트 색상을 검정색으로 변경
                txtPW.UseSystemPasswordChar = true; //  패스워드 입력란으로 설정하여 입력된 텍스트를 가리도록 함
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text)) // 텍스트가 비어있거나 공백인 경우에만 초기화
            {
                txtPW.UseSystemPasswordChar = false; // 패스워드 입력란 설정 해제하여 텍스트가 보이도록 함
                txtPW.Text = "패스워드"; // 텍스트를 "패스워드"로 초기화
                txtPW.ForeColor = Color.Silver; //  텍스트 색상을 은색으로 변경

            }
        }

        string myID = "admin"; // 로그인에 사용할 아이디를 변수에 저장
        string myPW = "superman"; // 로그인에 사용할 패스워드를 변수에 저장

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; // 입력된 아이디를 변수에 저장
            string inputPW = txtPW.Text; // 입력된 패스워드를 변수에 저장

            if (inputID == myID && inputPW == myPW) // 입력된 아이디와 패스워드가 저장된 아이디와 패스워드와 일치하는지 확인
            {
                MessageBox.Show("로그인 성공!"); // 로그인 성공 메시지 박스 표시
                lblErrorMsg.Visible = false; // 오류 메시지 라벨 숨김
            }
            else
            {
                // MessageBox.Show("로그인 실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error); // 로그인 실패 메시지 박스 표시
                lblErrorMsg.Visible = true; // 오류 메시지 라벨 표시
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 키가 눌렸는지 확인
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                txtPW.Focus(); // 패스워드 입력란으로 포커스 이동
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 키가 눌렸는지 확인
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                btnLogin.PerformClick(); // 버튼이 눌린 것처럼 만들기
            }
        }
    }
}