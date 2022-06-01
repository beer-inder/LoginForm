using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class Login_Class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Reader_Login;
        string QueryString;
        int number = 0;

        public Login_Class()
        {
            string ConnString = @"Data Source=T2181\SQLEXPRESS;Initial Catalog=Music;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }
        
        public string Login(string username, string password)
        {
            try
            {
                Cmd.Connection = Obj_Conn;
                QueryString = "Select UserName, Password from UserDetails where UserName =  @UserName  and Password =  @Password ";
                Cmd.Parameters.AddWithValue("@UserName", username);
                Cmd.Parameters.AddWithValue("@Password", password);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();

                // get data stream
                Reader_Login = Cmd.ExecuteReader();
                if (Reader_Login.HasRows)
                {
                    return "User Login Successfully"; ;
                }
                else
                {
                    return "User details are not correct";
                }
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string GenerateCaptcha()
        {
            
            Random ran_num = new Random();
            number = ran_num.Next(9999, 99999);
            return number.ToString();
        }


        public bool ValidateCaptcha(string userCaptcha)
        {
            if (number.ToString() == userCaptcha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
