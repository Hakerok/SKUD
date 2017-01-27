using SKYD.Classes.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYD.Forms
{
    public partial class update_turnstiles : Form
    {
        public update_turnstiles()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text) || !String.IsNullOrEmpty(local.Text) || !String.IsNullOrEmpty(ip.Text))
            {
              if(MessageBox.Show(@"Сохранить значения?",@"Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
              {
                  Add_Click(null,null);
              }
                else
              {
                  Close();
              }
            }
            else
            {
                Close();
            }
           
        }

        private void Add_Click(object sender, EventArgs e)
        {   
            SqlClass sqlclass = new SqlClass();
            if (!String.IsNullOrEmpty(name.Text) && !String.IsNullOrEmpty(local.Text) && !String.IsNullOrEmpty(ip.Text))
            {
                var dob = new SqlCommand { CommandType = CommandType.Text };
                try
                {
                    dob.CommandText = string.Format(@"Insert into dbo.turnstiles (name_turnstiles, location, ip_adress, statys) 
                                      values (N'{0}', N'{1}', N'{2}',N'{3}')",
                        name.Text, local.Text, ip.Text, 0);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                dob.Connection = sqlclass.SqlCon;
                sqlclass.SqlCon.Close();
                try
                {
                    sqlclass.SqlCon.Open();
                    dob.ExecuteNonQuery();
                    sqlclass.SqlCon.Close();
                    MessageBox.Show(@"Добавленно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                
            }
            else
            {
                MessageBox.Show(@"Поля не должны быть пустыми", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
