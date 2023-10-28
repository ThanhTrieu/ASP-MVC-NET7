using Microsoft.Data.SqlClient;
using Tranning.Models;

namespace Tranning.Queries
{
    public class LoginQueries
    {
        // chua cac logic sql xu ly voi database
        public LoginModel CheckLoginUser(string username, string password)
        {
            LoginModel dataUser = new LoginModel();
            using (SqlConnection conn = DatabaseConnection.GetSqlConnection())
            {
                string querySql = "SELECT * FROM users WHERE username = @username AND password = @password";
                // @username va @password : tham so truyen vao cau lenh sql voi gia tri dc nhan tu 2 bien string username va string password

                // tao 1 doi tuong command de thuc thi cau lenh sql
                SqlCommand cmd = new SqlCommand(querySql, conn);
                // xu ly truyen gia tri vao cho tham so trong sql
                cmd.Parameters.AddWithValue("@username", username ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@password", password ?? (object)DBNull.Value);
                // mo ket noi toi database
                conn.Open();
                // thuc thi lenh sql
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // do du lieu tu table trong database vao model minh da dinh nghia
                        dataUser.UserID = reader["id"].ToString();
                        dataUser.Username = reader["username"].ToString();
                        dataUser.EmailUser = reader["email"].ToString();
                        dataUser.RoleID = reader["role_id"].ToString();
                        dataUser.PhoneUser = reader["phone"].ToString();
                        dataUser.FullName = reader["full_name"].ToString();
                        dataUser.ExtraCode = reader["extra_code"].ToString();
                    }
                    // ngat ket noi toi database
                    conn.Close();
                }
            }
            return dataUser;
        }
    }
}
