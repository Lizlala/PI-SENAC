namespace LoginPage
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Cadastrar = new Label();
            label4 = new Label();
            Senha = new Label();
            txtSenha = new TextBox();
            Usuario = new Label();
            Titulo = new Label();
            btnEntrar = new Button();
            txtUsuario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(Cadastrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Senha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(Usuario);
            panel1.Controls.Add(Titulo);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(440, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 493);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // Cadastrar
            // 
            Cadastrar.AutoSize = true;
            Cadastrar.BackColor = Color.Transparent;
            Cadastrar.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cadastrar.ForeColor = Color.FromArgb(166, 107, 45);
            Cadastrar.Location = new Point(164, 405);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(142, 22);
            Cadastrar.TabIndex = 14;
            Cadastrar.Text = "Cadastre-se";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(166, 107, 45);
            label4.Location = new Point(148, 277);
            label4.Name = "label4";
            label4.Size = new Size(238, 22);
            label4.TabIndex = 13;
            label4.Text = "Esqueci minha senha";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.BackColor = Color.Transparent;
            Senha.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Senha.ForeColor = Color.FromArgb(166, 107, 45);
            Senha.Location = new Point(45, 205);
            Senha.Name = "Senha";
            Senha.Size = new Size(70, 22);
            Senha.TabIndex = 12;
            Senha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(243, 243, 243);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.SaddleBrown;
            txtSenha.Location = new Point(45, 230);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(341, 35);
            txtSenha.TabIndex = 11;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.BackColor = Color.Transparent;
            Usuario.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.ForeColor = Color.FromArgb(166, 107, 45);
            Usuario.Location = new Point(45, 120);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(94, 22);
            Usuario.TabIndex = 10;
            Usuario.Text = "Usuario";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Goudy Old Style", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.FromArgb(181, 125, 29);
            Titulo.Location = new Point(164, 37);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(241, 51);
            Titulo.TabIndex = 3;
            Titulo.Text = "Fio de Ouro";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(197, 138, 23);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(45, 345);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(341, 42);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(243, 243, 243);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.SaddleBrown;
            txtUsuario.Location = new Point(45, 145);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 35);
            txtUsuario.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(1333, 827);
            Name = "Login";
            Text = "Login";
            Resize += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox txtUsuario;
        private Label Usuario;
        private Label Titulo;
        private Button btnEntrar;
        private Label Cadastrar;
        private Label label4;
        private Label Senha;
        private TextBox txtSenha;
    }
}
