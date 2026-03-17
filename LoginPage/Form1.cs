namespace LoginPage
{
    using System.Drawing;
    using System.Runtime.InteropServices;
    public partial class Login : Form //VARIAVEIS CADASTRO
    {
        string usuarioCadastro = "";
        string usuarioSenha = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//DESIGNER ARREDONDADO 

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Login() //cONTRUTOR 
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));

            txtUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUsuario.Width, txtUsuario.Height, 20, 20));

            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtSenha.Width, txtSenha.Height, 20, 20));

            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEntrar.Width, btnEntrar.Height, 30, 30));

        }

        private void CentralizarPanel1() //CENTRALIZAR TELA LOGIN
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
        private void Login_Load(object sender, EventArgs e) //CENTRALIZAR NA WEB
        {
             CentralizarPanel1();
            CentralizarCampos();
        }

        private void login_Resize(object sender, EventArgs e) //REDIMENCIONAR A TELA E N MUDAR O PADRAO
        {
            CentralizarPanel1();
            CentralizarCampos();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e) //BOTAO CADASTRAR
        {
            usuarioCadastro = txtUsuario.Text;
            usuarioSenha = txtSenha.Text;
            MessageBox.Show("Cadastrado com sucesso!");
        }


        private void btnEntrar_Click(object sender, EventArgs e) //BOTAO ENTRAR
        {
            if (txtUsuario.Text == usuarioCadastro && txtSenha.Text == usuarioSenha)
            {
                MessageBox.Show("Login Realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void CentralizarCampos()
        {
            Titulo.Left = (panel1.ClientSize.Width - Titulo.Width) / 2;

            txtUsuario.Left = (panel1.ClientSize.Width - txtUsuario.Width) / 2;
            txtSenha.Left = (panel1.ClientSize.Width - txtSenha.Width) / 2;
            btnEntrar.Left = (panel1.ClientSize.Width - btnEntrar.Width) / 2;
            Cadastrar.Left = (panel1.ClientSize.Width - Cadastrar.Width) / 2;
            
            Usuario.Left = txtUsuario.Left;
            Senha.Left = txtSenha.Left;

            Usuario.Top = txtUsuario.Top - 20;
            Senha.Top = txtSenha.Top - 20;

        }
    }
}
