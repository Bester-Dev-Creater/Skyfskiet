using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DataHandler
{
    // Data Source = CHARLBESTERASUS; Initial Catalog = EldoraigneSkyfskiet; Integrated Security = True

    public class DBAccess
    {
        SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder();

        public DBAccess()
        {
            SqlConnectionStringBuilder.DataSource = "CHARLBESTERASUS";
            SqlConnectionStringBuilder.InitialCatalog = "EldoraigneSkyfskietDB";
            SqlConnectionStringBuilder.IntegratedSecurity = true;
        }

        public DataSet ReadDataFromDB(string tableName)
        {
            DataSet rawdata = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                string readQry = string.Format("SELECT * FROM {0}", tableName);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(readQry, sqlConnection))
                {
                    sqlDataAdapter.FillSchema(rawdata, SchemaType.Source, tableName);
                    sqlDataAdapter.Fill(rawdata, tableName);
                }
            }
            return rawdata;
        }

        public void InsertNewShooter(string name, string surname, string iDnumber, string phone, string email, string parentName, string parentEmail, string parentPhone, string notes, bool scope, bool tripod, bool mat, bool kneeRoll)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("InsertShooterData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Name", name);
                    sqlCommand.Parameters.AddWithValue("@Surname", surname);
                    sqlCommand.Parameters.AddWithValue("@IDNumber", iDnumber);
                    sqlCommand.Parameters.AddWithValue("@Phone", phone);
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@ParentName", parentName);
                    sqlCommand.Parameters.AddWithValue("@ParentEmail", parentEmail);
                    sqlCommand.Parameters.AddWithValue("@ParentPhone", parentPhone);
                    sqlCommand.Parameters.AddWithValue("@Notes", notes);
                    sqlCommand.Parameters.AddWithValue("@Scope", scope);
                    sqlCommand.Parameters.AddWithValue("@Tripod", tripod);
                    sqlCommand.Parameters.AddWithValue("@Mat", mat);
                    sqlCommand.Parameters.AddWithValue("@KneeRoll", kneeRoll);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateShooter(int id, string name, string surname, string phone, string iDnumber, string email, string parentName, string parentEmail, string parentPhone, string notes, bool scope, bool tripod, bool mat, bool kneeRoll)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("UpdateShooterData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@Name", name);
                    sqlCommand.Parameters.AddWithValue("@Surname", surname);
                    sqlCommand.Parameters.AddWithValue("@Phone", phone);
                    sqlCommand.Parameters.AddWithValue("@IDNumber", iDnumber);
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@ParentName", parentName);
                    sqlCommand.Parameters.AddWithValue("@ParentEmail", parentEmail);
                    sqlCommand.Parameters.AddWithValue("@ParentPhone", parentPhone);
                    sqlCommand.Parameters.AddWithValue("@Notes", notes);
                    sqlCommand.Parameters.AddWithValue("@Scope", scope);
                    sqlCommand.Parameters.AddWithValue("@Tripod", tripod);
                    sqlCommand.Parameters.AddWithValue("@Mat", mat);
                    sqlCommand.Parameters.AddWithValue("@KneeRoll", kneeRoll);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteShooter(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DeleteShooterData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@id", id);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void InsertGunData(string manufacturer, string model, string condition, string comments, string serial)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("InsertGunData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@manufacturer", manufacturer);
                    sqlCommand.Parameters.AddWithValue("@model", model);
                    sqlCommand.Parameters.AddWithValue("@condition", condition);
                    sqlCommand.Parameters.AddWithValue("@comments", comments);
                    sqlCommand.Parameters.AddWithValue("@serial", serial);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateGunData(int id, string manufacturer, string model, string condition,  string comments, string serial)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("UpdateGunData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    sqlCommand.Parameters.AddWithValue("@model", model);
                    sqlCommand.Parameters.AddWithValue("@condition", condition);
                    sqlCommand.Parameters.AddWithValue("@comments", comments);
                    sqlCommand.Parameters.AddWithValue("@serial", serial);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteGunData(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DeleteGunData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@id", id);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataSet AvailableGuns()
        {

            DataSet rawdata = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                string readQry = string.Format("Select * from tblGuns where tblGuns.GunID not in (select GunId from tblGunsBorrowed)");
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(readQry, sqlConnection))
                {
                    sqlDataAdapter.FillSchema(rawdata, SchemaType.Source, "tblGuns");
                    sqlDataAdapter.Fill(rawdata, "tblGuns");
                }
            }
            return rawdata;
        }

        public void InsertBorrowedGunData(int gunId, bool raiserblok, bool band,int shooterid,string dayout)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("InsertBorowedData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@gun", gunId);
                    sqlCommand.Parameters.AddWithValue("@raiser", raiserblok);
                    sqlCommand.Parameters.AddWithValue("@band", band);
                    sqlCommand.Parameters.AddWithValue("@shooter", shooterid);
                    sqlCommand.Parameters.AddWithValue("@dayOut", dayout);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBorrowedGunData(int gunID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DeleteBorowedData", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@gun", gunID);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }


    }
}
