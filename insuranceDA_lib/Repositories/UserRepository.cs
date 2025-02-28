using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
namespace insuranceDA_lib.Repositories
{
    public class UserRepository : IRepositoryUser<User>
    {
        SqlConnection con;
        public UserRepository()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public string ConnectionString
        {
            get
            {
                return "Data Source=LTIN400008;Initial Catalog=project;Integrated Security=True";
            }
        }
        public List<User> GetUserProfile()
        {
            throw new NotImplementedException();
        }

        public bool LoginUser(User entity)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User entity)
        {
            bool b = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users values(@p1,@p2,@p3)", con);
                //cmd.Parameters.Add("@p1", entity.CustomerId);
                cmd.Parameters.Add("@p1", entity.UserName);
                cmd.Parameters.Add("@p2", entity.Password);
                cmd.Parameters.Add("@p3", entity.Role);
         
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    b = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert Operation Failed -" + ex.Message);
                b = false;
            }
            return b;
        }
    }
}
