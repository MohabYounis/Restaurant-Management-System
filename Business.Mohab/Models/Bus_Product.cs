using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mohab.DataAcess;

namespace Mohab.Business
{
    public class Bus_Product
    {
        DBContext db;

        public Bus_Product()
        {
            db = new DBContext();
        }

        // Get All Products
        public DataTable GetAllProducts()
        {
            string commandText = "select * from Products";
            return db.ExecuteQuery(commandText);
        }
        // Get All Product in Specific Category
        public DataTable GetAllCategoryProducts(string category)
        {
            string commandText = $"select * from Products where Cat_Id = {category}";
            return db.ExecuteQuery(commandText);
        }

        public int AddItem(string name, int price, int categoryId)
        {
            string commandText = $"insert into Products Values ('{name}', {price}, {categoryId})";
            return db.ExecuteNonQuery(commandText);
        }
        public int UpdateItem(string name, int price, int prodId)
        {
            string commandText = $"update Products set Pro_Name = '{name}', Pro_Price = {price} where Pro_Id = {prodId}";
            return db.ExecuteNonQuery(commandText);
        }
        public int DeleteItem(int prodId)
        {
            string commandText = $"delete from Products where Pro_Id = {prodId}";
            return db.ExecuteNonQuery(commandText);
        }

        //public DataTable GetProductWithId(int id)
        //{
        //    string commandText = $"select * from Products where Pro_Id = {id}";
        //    return db.ExecuteQuery(commandText);
        //}
    }
}
