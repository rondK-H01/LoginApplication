using Microsoft.Data.SqlClient;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GFTTK8N;Initial Catalog=Loginapp;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM loginapp WHERE email=@email AND username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
