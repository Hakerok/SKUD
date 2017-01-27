using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using System.Data.SqlClient;
using SKYD.Forms;

namespace SKYD
{
    public partial class turnstiles : Form
    {
        SqlClass sqlclass = new SqlClass();
        public turnstiles()
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
            
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Table(DataGridView datagrid)
            {
                SqlClass sqlclass = new SqlClass();
                const string sqlDb = @"SELECT * FROM dbo.turnstiles";
                var sqlDa = new SqlDataAdapter(sqlDb, sqlclass.SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (var i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.turnstiles
                    {
                        Id = (int)dtMain.Rows[i]["Id_turnstiles"],
                        Name = dtMain.Rows[i]["name_turnstiles"].ToString(),
                        Location = dtMain.Rows[i]["location"].ToString(),
                        Ip_adress = dtMain.Rows[i]["ip_adress"].ToString(),
                        statys = Convert.ToInt32(dtMain.Rows[i]["statys"].ToString()),

                    };
                    if (0 == temp.statys )
                    {
                        datagrid.Rows.Add(temp.Id, temp.Name, temp.Location, temp.Ip_adress, @"Не в сети");
                    }
                    else
                    {
                        datagrid.Rows.Add(temp.Id, temp.Name, temp.Location, temp.Ip_adress, @"В сети");
                    }
                   
                }
                
            }
        
           
    }
}
