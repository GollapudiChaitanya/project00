using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.Repositories;
using insuranceBO_lib.models;
namespace insuranceBO_lib.BO
{
    public class UserBO
    {
        static UserRepository urepo = new UserRepository();


        public static void RegisterUser(User User)
        {
            insuranceDA_lib.models.User us = new insuranceDA_lib.models.User()
            {
                //CustomerId = customer.CustomerId,
                UserName = User.UserName,
                Password = User.Password,
                Role = User.Role,
               

            };

            if (urepo.RegisterUser(us))
            {
                Console.WriteLine("The user is registered succefully!");
            }
            else
            {
                Console.WriteLine("The User is not registered succefully!");
            }
        }
    }
}
