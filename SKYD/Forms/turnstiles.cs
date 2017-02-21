using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using SKYD.Classes.SQL;

namespace SKYD.Forms
{
    public partial class Turnstiles : Form
    {
        private void turnstiles_Load(object sender, EventArgs e)
        {
          
           
        }
        public Turnstiles()
        {
            InitializeComponent();
            Form1 main = new Form1();
            main.Hide();
            Table(dg);

        }

        private void add_Click(object sender, EventArgs e)
        {
            update_turnstiles uptturn = new update_turnstiles();
            uptturn.ShowDialog();
            Update();
            dg.Rows.Clear();
            Table(dg);

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dg.CurrentRow != null)
            {
                string ippole = dg[0, dg.CurrentRow.Index].Value.ToString();
                string name = dg[1, dg.CurrentRow.Index].Value.ToString();
                string local = dg[2, dg.CurrentRow.Index].Value.ToString();
                string ip = dg[3, dg.CurrentRow.Index].Value.ToString();
                update_turnstiles uptturn =new update_turnstiles(name,local,ip,ippole);
                uptturn.ShowDialog();
            }
            Update();
            dg.Rows.Clear();
            Table(dg);
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Вы действительно хотите удалить запись?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlClass sqlclass = new SqlClass();
                await sqlclass.SqlCon.OpenAsync();
                try
                {
                    SqlCommand sqlcomdell = new SqlCommand("DELETE FROM [turnstiles] WHERE Id_turnstiles = @ID", sqlclass.SqlCon);
                    Debug.Assert(dg.CurrentRow != null, string.Format("{0}", @"dg.CurrentRow != null"));
                    sqlcomdell.Parameters.AddWithValue("@ID", dg[0, dg.CurrentRow.Index].Value.ToString());
                    await sqlcomdell.ExecuteNonQueryAsync();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlclass.SqlCon.Close();
                    dg.Rows.Clear();
                    Table(dg);
                }
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public async void Table(DataGridView datagrid)
        {
            SqlClass sqlclass = new SqlClass();
            await sqlclass.SqlCon.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand sqlcomturn = new SqlCommand("SELECT * FROM [turnstiles]", sqlclass.SqlCon);
            try
            {
                sqlReader = await sqlcomturn.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    datagrid.Rows.Add(sqlReader["Id_turnstiles"], sqlReader["name_turnstiles"], sqlReader["location"], sqlReader["ip_adress"], sqlReader["statys"]);
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