using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using MetroFramework.Forms;

namespace SKYD.Forms
{
    public partial class Authorizationadd : MetroForm
    {
        private readonly string _nameuser;
        private readonly string _passw;
        public Authorizationadd()
        {
            InitializeComponent();
        }

        public Authorizationadd(string name, string passwords)
        {
            InitializeComponent();
            Text = @"Редактировать запись";
            textBox1.Text = name;
            textBox2.Text = passwords;
            button1.Text = @"Изменить";
            _nameuser = name;
            _passw = passwords;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != @"Изменить")
            {
                SqlClass sqlclass = new SqlClass();
                await sqlclass.SqlCon.OpenAsync();
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {

                    try
                    {
                        SqlCommand sqlcotyrnadd =
                            new SqlCommand("INSERT INTO [users] (Username, passwords) VALUES (@nameuser, @passwords)",
                                sqlclass.SqlCon);
                        sqlcotyrnadd.Parameters.AddWithValue("nameuser", textBox1.Text);
                        sqlcotyrnadd.Parameters.AddWithValue("passwords", textBox2.Text);
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
                    MessageBox.Show(@"Поля не должны быть пустыми", @"Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textBox1.Text == _nameuser && textBox2.Text == _passw)
                {
                    if (MessageBox.Show(@"Данная запись не была отредактированна закрыть без изменения?", @"Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                        {
                            try
                            {
                                SqlCommand sqlcoupdate = new SqlCommand("UPDATE [users] SET [Username] = '"+textBox1.Text+"', [passwords] = '"+textBox2.Text+"' WHERE [Username] = '"+_nameuser+"'", sqlclass.SqlCon);
                                MessageBox.Show(@"Измененно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await sqlcoupdate.ExecuteNonQueryAsync();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text))
            {
                if (MessageBox.Show(@"Сохранить значения?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button1_Click(null, null);
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
    }
}
