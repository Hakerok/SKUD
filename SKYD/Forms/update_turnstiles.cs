using SKYD.Classes.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SKYD.Forms
{
    public partial class update_turnstiles : Form
    {
        private string idupdate;
        private string nameupdate;
        private string localupdate;
        private string ipupdate;
        public update_turnstiles()
        {
            InitializeComponent();
           
        }
        public update_turnstiles(string name, string localturn, string apdate, string id)
        {
            InitializeComponent();
            Add.Text = "Изменить";
            nameturn.Text = name;
            local.Text = localturn;
            ipadress.Text = apdate;
            idupdate = id;
            nameupdate = name;
            localupdate = localturn;
            ipupdate = apdate;

        }
        private  void back_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameturn.Text) || !String.IsNullOrEmpty(local.Text) || !String.IsNullOrEmpty(ipadress.Text))
            {
                if (MessageBox.Show(@"Сохранить значения?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Add_Click(null, null);
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
        private async void Add_Click(object sender, EventArgs e)
        {
            if (idupdate == null)
            {
                SqlClass sqlclass = new SqlClass();
                await sqlclass.SqlCon.OpenAsync();
                if (!String.IsNullOrEmpty(nameturn.Text) && !String.IsNullOrEmpty(local.Text) && !String.IsNullOrEmpty(ipadress.Text))
                {
                    
                    try
                    {
                        SqlCommand sqlcotyrnadd = new SqlCommand("INSERT INTO [turnstiles] (name_turnstiles, location, ip_adress, statys) VALUES (@name_turnstiles, @location, @ip_adress, @statys)", sqlclass.SqlCon);
                        sqlcotyrnadd.Parameters.AddWithValue("name_turnstiles", nameturn.Text);
                        sqlcotyrnadd.Parameters.AddWithValue("location", local.Text);
                        sqlcotyrnadd.Parameters.AddWithValue("ip_adress", ipadress.Text);
                        sqlcotyrnadd.Parameters.AddWithValue("statys", 0);
                        await sqlcotyrnadd.ExecuteNonQueryAsync();
                        MessageBox.Show(@"Добавленно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlclass.SqlCon.Close();
                    }
                }
                else
                {
                    MessageBox.Show(@"Поля не должны быть пустыми", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (nameturn.Text == nameupdate && local.Text == localupdate && ipadress.Text == ipupdate)
                {
                  if( MessageBox.Show(@"Данная запись не была отредактированна закрыть без изменения?", @"Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                  {
                      Close();
                  }
                }
                else
                {
                    if (MessageBox.Show(@"Вы действительно хотите отредактировать?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlClass sqlclass = new SqlClass();
                        await sqlclass.SqlCon.OpenAsync();
                        if (!String.IsNullOrEmpty(nameturn.Text) && !String.IsNullOrEmpty(local.Text) && !String.IsNullOrEmpty(ipadress.Text))
                        {
                            try
                            {
                                SqlCommand sqlcoupdate = new SqlCommand("UPDATE [turnstiles] SET [name_turnstiles] = @newname, [location] = @newlocal, [ip_adress] =@newipad , [statys] = @newstatys WHERE [Id_turnstiles] = @ID", sqlclass.SqlCon);
                                sqlcoupdate.Parameters.AddWithValue("@ID", idupdate);
                                sqlcoupdate.Parameters.AddWithValue("@newname", nameturn.Text);
                                sqlcoupdate.Parameters.AddWithValue("@newlocal", local.Text);
                                sqlcoupdate.Parameters.AddWithValue("@newipad", ipadress.Text);
                                sqlcoupdate.Parameters.AddWithValue("@newstatys", 0);
                                await sqlcoupdate.ExecuteNonQueryAsync();

                                MessageBox.Show(@"Измененно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlclass.SqlCon.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Поля не должны быть пустыми", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
        }
        private void ipadress_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown: {0}", e.KeyValue);
        }

        private void ipadress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress: {0}", Convert.ToInt32(e.KeyChar));
        }

        private void ipadress_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyUp: {0}", e.KeyValue);
        }
    }
}

