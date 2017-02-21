using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SKYD.Classes.SQL
{
    public class SqlClass
    {
        public SqlConnection SqlCon = new SqlConnection(
                 @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Игорь\Documents\GitHub\SKUD\SKYD\skyd.mdf;Integrated Security=True");


        public async void Combobox(ComboBox unitcb, ComboBox dormcb)
        {
            unitcb.Items.Add(@"Подразделения");
            dormcb.Items.Add(@"Номер общежития");
            unitcb.SelectedIndex = 0;
            dormcb.SelectedIndex = 0;
            await SqlCon.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand sqlcomdorm = new SqlCommand("SELECT * FROM [dorm]", SqlCon);
            SqlCommand sqlcomunit = new SqlCommand("SELECT * FROM [unit]", SqlCon);
            try
            {
                sqlReader = await sqlcomdorm.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    dormcb.Items.Add(sqlReader["name_dorm"]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (sqlReader != null) sqlReader.Close();
                sqlReader = await sqlcomunit.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    unitcb.Items.Add(sqlReader["name_Unit"]);
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

        public async void Comboboxad(ComboBox subdivisioncb, ComboBox unitcb)
        {
            if (SqlCon != null){SqlCon.Close();}
            subdivisioncb.Items.Clear();
            if (unitcb.SelectedIndex == 1)
            {
                if (SqlCon != null)
                {
                    await SqlCon.OpenAsync();
                    SqlDataReader sqlReader = null;
                    SqlCommand sqlcomturn = new SqlCommand("SELECT * FROM [faculties]", SqlCon);
                    try
                    {
                        sqlReader = await sqlcomturn.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            subdivisioncb.Items.Add(sqlReader["name_faculties"]);
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
            if (unitcb.SelectedIndex == 3)
            {
                if (SqlCon != null)
                {
                    await SqlCon.OpenAsync();
                    SqlDataReader sqlReader = null;
                    SqlCommand sqlcomturn = new SqlCommand("SELECT * FROM [fpps]", SqlCon);
                    try
                    {
                        sqlReader = await sqlcomturn.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            subdivisioncb.Items.Add(sqlReader["name_fpps"]);
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
        public void Comboboxcourses(ComboBox subdivisioncb, ComboBox coursescb)
        {
            coursescb.Items.Clear();
            if (subdivisioncb.SelectedIndex == 1 || subdivisioncb.SelectedIndex == 2 || subdivisioncb.SelectedIndex == 4)
            {
                coursescb.Items.Add(@"Курс");
                coursescb.SelectedIndex = 0;
               
            }
            if (subdivisioncb.SelectedIndex == 3 || subdivisioncb.SelectedIndex == 5)
            {
                coursescb.Items.Add(@"Курс");
                coursescb.SelectedIndex = 0;
               
            }
            if (subdivisioncb.SelectedIndex == 6)
            {
                
            }
        }

        /*  public void tablemain(DataGridView datagrid)
          {

              SqlClass sqlclass = new SqlClass();
              const string sqlDb = @"SELECT * FROM dbo.main 
              INNER JOIN dbo.unit		ON dbo.main.id_unit = dbo.unit.id_Unit
              INNER JOIN dbo.keyss    ON dbo.main.id_key = dbo.keyss.Id_keys
              LEFT JOIN dbo.dorm		ON dbo.main.id_dorm = dbo.dorm.id_dorm
              LEFT JOIN dbo.faculties	ON dbo.main.id_facult = dbo.faculties.id_faculties";
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
                  var temp = new BdClass.main
                  {
                      Id = (int)dtMain.Rows[i]["Id"],
                      Surname = dtMain.Rows[i]["Surname"].ToString(),
                      Name = dtMain.Rows[i]["Name"].ToString(),
                      middle_name = dtMain.Rows[i]["middle_name"].ToString(),
                      number_of_record_book = dtMain.Rows[i]["number_of_record-book"].ToString(),
                      group = dtMain.Rows[i]["Group"].ToString(),
                  };
                  temp.unit = new BdClass.Unit
                  {
                      Id = (int)dtMain.Rows[i]["Id_Unit"],
                      Name = dtMain.Rows[i]["name_Unit"].ToString()
                  };
                  temp.dorm = new BdClass.Dorm();
                  var dor = dtMain.Rows[i]["Id_dorm"].ToString() != ""
                    ? dtMain.Rows[i]["name_dorm"].ToString()
                    : null;
                  temp.dorm.Name = dor;
                  temp.key = new BdClass.Key
                  {
                      Id = (int)dtMain.Rows[i]["Id_keys"],
                      Name = dtMain.Rows[i]["name"].ToString()
                  };
                  temp.faculties = new BdClass.Faculties();
                  var facul = dtMain.Rows[i]["Id_faculties"].ToString() != ""
                    ? dtMain.Rows[i]["name_faculties"].ToString()
                    : null;
                  temp.faculties.Name = facul;
                  datagrid.Rows.Add(temp.Id, temp.Surname, temp.Name, temp.middle_name, temp.number_of_record_book, temp.unit.Name, temp.faculties.Name, temp.group, temp.dorm.Name, temp.key.Name);
                  SqlCon.Close();

              }
          }
          }
      }
  */
    }
}