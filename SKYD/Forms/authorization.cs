using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using SKYD.Classes.SQL;

namespace SKYD.Forms
{
    public partial class Authorization : MetroFramework.Forms.MetroForm
    {
        SqlClass _sqlClass = new SqlClass();
        public Authorization()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(60);
                Opacity = Opacity + 0.1;
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter aqlAdapter =
                new SqlDataAdapter(
                    "SELECT COUNT (*) FROM users WHERE Username ='" + metroTextBox1.Text + "'and passwords = '" + metroTextBox2.Text + "'",
                    _sqlClass.SqlCon);
            DataTable dataTable = new DataTable();
            aqlAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show(@"Здравствуйте: " + metroTextBox1.Text , @"Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Form1 form1 = new Form1();
                form1.Show();
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(60);
                    Opacity = Opacity - 0.1;
                }

            }
            else
            {
                MessageBox.Show(@"Неверное имя пользователя или пароль!", @"Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
