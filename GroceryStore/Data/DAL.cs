using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace GroceryStore.Data
{
    class DAL
    {
        public SqlConnection con = new SqlConnection("server=.;Database=GroceryStoreMIS;Trusted_Connection=True;MultipleActiveResultSets=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlDataReader dr;
        // public DataTable dt = new DataTable();

        public void connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {

            }

        }

        public void disconnect()
        {

            try
            {

                con.Close();
            }
            catch (Exception e)
            {

            }

        }

        public bool Login(String username, string password)
        {
            connect();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users WHERE username ='" + username + "' AND password = '" + password + "'";
            dr = cmd.ExecuteReader();
            dr.Read();

            bool result = dr.HasRows;// 'HasRows' will determine
            // whether one or more than one row or record selected
            // or not, if yes, it will return 'True', Otherwise 
            // retrun 'Fale'.

            //If we return directly 'dr.Hasrows', we will not be 
            //able to disconnect database(After retrun key word
            // the execution will stop).On the other hand, if we
            // disconnect first and then want to return value that is 
            // not possible because 'dr.Hasrows' is Disconnected Class.
            // and after disconneting the value will lost.
            // that is why we have stored the value in 'result' vaiable
            disconnect();
            return result;

        }
    }
}
