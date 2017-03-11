using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using MetroFramework.Forms;

namespace SKYD.Forms
{
    public partial class Authorizationdatabase : MetroForm
    {
        public Authorizationdatabase()
        {
            InitializeComponent();
            Table();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Authorizationadd authorizationadd = new Authorizationadd();
            authorizationadd.ShowDialog();
            dataGridView1.Rows.Clear();
            Table();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string nameuser = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string passwords = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                Authorizationadd authorizationadd = new Authorizationadd(nameuser,passwords);
                authorizationadd.ShowDialog();
                dataGridView1.Rows.Clear();
                Table();
            }
        }

        private async void del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Вы действительно хотите удалить запись?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlClass sqlclass = new SqlClass();
                await sqlclass.SqlCon.OpenAsync();
                try
                {
                    SqlCommand sqlcomdell = new SqlCommand("DELETE FROM [users] WHERE Username = @name", sqlclass.SqlCon);
                    Debug.Assert(dataGridView1.CurrentRow != null, string.Format("{0}", @"dg.CurrentRow != null"));
                    sqlcomdell.Parameters.AddWithValue("@name", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    await sqlcomdell.ExecuteNonQueryAsync();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlclass.SqlCon.Close();
                    dataGridView1.Rows.Clear();
                    Table();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Table()
        {
            SqlClass sqlclass = new SqlClass();
            await sqlclass.SqlCon.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand sqlcomturn = new SqlCommand("SELECT * FROM [users]", sqlclass.SqlCon);
            try
            {
                sqlReader = await sqlcomturn.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    dataGridView1.Rows.Add(sqlReader["Username"], sqlReader["passwords"]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
    }
}
