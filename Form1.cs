namespace Salvataggio_e_accesso_con_user_e_pwd
{
    public partial class Form1 : Form
    {
        
        GestioneFile gestioneFile = new GestioneFile();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Invio_Click(object sender, EventArgs e)
        {
            string usernameSalvato = gestioneFile.leggi_fileDiTesto("FileUsername", "txt", 
                    Directory.GetCurrentDirectory()).Trim().ToUpper();
            string passwordSalvata = gestioneFile.leggi_fileDiTesto("FilePassword", "txt", 
                    Directory.GetCurrentDirectory()).Trim().ToUpper();
            if (txt_Username.Text.ToUpper().Trim() == usernameSalvato && txt_Password.Text.ToUpper().Trim() == passwordSalvata)
            {
                MessageBox.Show("Accesso corretto");
                txt_Username.BackColor = Color.Green;
                txt_Password.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Username o password errati, accesso negato", "ATTENZIONE");
                txt_Username.BackColor = Color.Red;
                txt_Password.BackColor = Color.Red;
            }
        }

        public void btn_Registrati_Click(object sender, EventArgs e)
        {
            gestioneFile.scrivi_fileDiTesto(txt_Username.Text, Directory.GetCurrentDirectory(), "FileUsername", "txt");
            gestioneFile.scrivi_fileDiTesto(txt_Password.Text, Directory.GetCurrentDirectory(), "FilePassword", "txt");
        }

        public void btl_LeggiTesto_Click(object sender, EventArgs e)
        {
            txt_Username.Text = gestioneFile.leggi_fileDiTesto("FileUsername", "txt", Directory.GetCurrentDirectory()).Trim();
            txt_Password.Text = gestioneFile.leggi_fileDiTesto("FilePassword", "txt", Directory.GetCurrentDirectory()).Trim();
        }

        private void txt_ChangeColor(object sender, EventArgs e)
        {
            if (txt_Password.Text == "" && txt_Username.Text == "")
            {
                txt_Username.BackColor = Color.White;
                txt_Password.BackColor = Color.White;
            }
        } 
    }
}
