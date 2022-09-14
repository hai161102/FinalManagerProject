using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.db.dao
{
    internal class Dao
    {
        private const String DB_PATH = @"Data Source=HAI;Initial Catalog=btOnClass;Integrated Security=True";
        private SqlConnection sqlConnection = new SqlConnection(DB_PATH);

        public Dao()
        {
            openDataBase();
        }

        public void openDataBase()
        {
            try
            {
                sqlConnection.Open();

            }
            catch (Exception)
            {

            }
        }

        public void closeDataBase()
        {
            try
            {
                sqlConnection.Close();

            }
            catch (Exception)
            {

            }
        }

        public bool isOpenDataBase()
        {
            return sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public List<AccountLogin> getListAccountFromDB()
        {
            openDataBase();
            List<AccountLogin> list = new List<AccountLogin>();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Account", sqlConnection);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    AccountLogin accountLogin = new AccountLogin();
                    accountLogin.setUserName(sqlDataReader.GetString(1));
                    accountLogin.setPassword(sqlDataReader.GetString(2));
                    accountLogin.setKeyPermission(sqlDataReader.GetString(3));
                    list.Add(accountLogin);
                }
            }
            catch (Exception)
            {

            }
            closeDataBase();
            return list;
        }

        [Obsolete]
        public void CreateAccount(AccountLogin account)
        {

            openDataBase();
            SqlCommand sqlCommand = new SqlCommand("insert into Account (userName, pass, permissionKey) values (@userName, @pass, @permissionKey)",
                sqlConnection);
            sqlCommand.Parameters.Add("@userName", value: account.getUserName().Trim());
            sqlCommand.Parameters.Add("@pass", value: account.getPassword().Trim());
            sqlCommand.Parameters.Add("@permissionKey", value: account.getPermissionKey().Trim());
            sqlCommand.ExecuteNonQuery();
    

            closeDataBase();
        }
        
    }
}
