using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mohab.DataAcess;


namespace Mohab.Business
{
    public class Bus_User
    {
        DBContext dbContext;

        public Bus_User()
        {
            dbContext = new DBContext();
        }

        // Check existance of user by email and password (for login form)
        public DataTable GetUser(string email, string password)
        {
            string commandText = $"select * from Users where U_Email = '{email}' and U_Pass = '{password}'";
            return dbContext.ExecuteQuery(commandText);
        }

        // Check existance of user by email (for signup form)
        public DataTable NewUserCheckByEmail(string email)
        {
            string commandText = $"select * from Users where U_Email = '{email}'";
            return dbContext.ExecuteQuery(commandText);
        }

        // Add User (for signup form)
        public int Add(string name, string pass, string email, int age, string address)
        {
            string commandText = $"insert into Users (U_Name, U_Pass, U_Email, U_Age, U_Add) values ('{name}', '{pass}', '{email}', {age}, '{address}')";
            return dbContext.ExecuteNonQuery(commandText);
        }

        // Select All Users
        public DataTable SelectAllUsers()
        {
            string commandText = $"select * from users";
            return dbContext.ExecuteQuery(commandText);
        }

        // Edit Role (user or admin)
        public int EditRole(string userRole, int userId)
        {
            string commandText = $"update users set U_Role = '{userRole}' where U_Id = {userId}";
            return dbContext.ExecuteNonQuery(commandText);
        }

        // Delete User or Admin
        public int DeleteUserOrAdmin(int userId)
        {
            string commandText = $"delete from users where U_Id = {userId}";
            return dbContext.ExecuteNonQuery(commandText);
        }

        // Get User Name by Id
        public string GetUserNameById(int userId)
        {
            string commandText = $"SELECT U_Name FROM users WHERE U_Id = {userId}";
            DataTable result = dbContext.ExecuteQuery(commandText);

            return result.Rows.Count > 0 ? (result.Rows[0][0]).ToString() : "";
        }

    }
}
