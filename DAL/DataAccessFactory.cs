using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
        public static IRepo<User, int, User> UserAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Farmer, int, Farmer> FarmerDataAccess()
        {
            return new FarmerRepo();
        }
        public static IAuth<bool> AuthDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Customer, int, Customer> CustomerAccess()
        {
            return new CustomerRepo();
        }
        public static IRepo<Comment, int, Comment> CommentAccess()
        {
            return new CommentRepo();
        }
    }
}
