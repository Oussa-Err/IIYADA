using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestionCabinie
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLogin.Text == "" || this.txtPassword.Text == "")
                {
                    MessageBox.Show("login et/ou password vide");
                }
                User u = new User(this.txtLogin.Text, this.txtPassword.Text);
                u.authantifier();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.txtLogin.Clear();
                this.txtPassword.Clear();
            }
        }
        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseConnection.connection.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
