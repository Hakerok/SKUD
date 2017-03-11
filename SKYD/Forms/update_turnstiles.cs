using SKYD.Classes.SQL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SKYD.Forms
{
    public partial class UpdateTurnstiles : MetroForm
    {
        private readonly string _idupdate;
        private readonly string _nameupdate;
        private readonly string _localupdate;
        private readonly string _ipupdate;
        public UpdateTurnstiles()
        {
            InitializeComponent();
           
        }
        public UpdateTurnstiles(string name, string localturn, string apdate, string id)
        {
            InitializeComponent();
            Add.Text = @"Изменить";
            nameturn.Text = name;
            local.Text = localturn;
            ipadress.Text = apdate;
            _idupdate = id;
            _nameupdate = name;
            _localupdate = localturn;
            _ipupdate = apdate;
            Text = @"Редактирование записи";

        }
        private  void back_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameturn.Text) || !String.IsNullOrEmpty(local.Text) || !String.IsNullOrEmpty(ipadress.Text))
            {
                if (MessageBox.Show(@"Сохранить значения?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Add_Click();
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
            if (_idupdate == null)
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
                        MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (nameturn.Text == _nameupdate && local.Text == _localupdate && ipadress.Text == _ipupdate)
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
                                sqlcoupdate.Parameters.AddWithValue("@ID", _idupdate);
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
                                MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Add_Click()
        {

        }
      
    }
}

