using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mohab.DataAcess;

namespace Mohab.Business
{
    public class Bus_Favourit
    {
        DBContext db;
        
        public Bus_Favourit() 
        {
            db = new DBContext();
        }

        // Add Item To Favourite
        public int AddItemToFavourite(int U_id, int Prod_id)
        {
            string commandText = $"if not exists (select * from Favourits where U_Id = {U_id} and Pro_Id = {Prod_id}) insert into Favourits Values ({U_id}, {Prod_id})";
            return db.ExecuteNonQuery(commandText);
        }

        // Delete Item From Favourite
        public int DeleteItemFromfvourite(int U_id, int Prod_id)
        {
            string commandText = $"delete from Favourits where U_Id = {U_id} and Pro_Id = {Prod_id}";
            return db.ExecuteNonQuery(commandText);
        }

        // Get All Favourite Products
        public DataTable GetAllFavProducts(int U_id)
        {
            string commandText = $"select P.Pro_Id, P.Pro_Name, P.Pro_Price, P.Cat_Id, U.U_Id  from Favourits F inner join Products P on F.Pro_Id = P.Pro_Id inner join Users U on F.U_Id = U.U_Id where U.U_Id = {U_id}";
            return db.ExecuteQuery(commandText);
        }
        // Get Specified Category From Favourite Products
        public DataTable GetAllFavProducts(string Category, int U_id)
        {
            string commandText = $"select  P.Pro_Id, P.Pro_Name, P.Pro_Price, P.Cat_Id, U.U_Id from Favourits F inner join Products P on F.Pro_Id = P.Pro_Id inner join Users U on F.U_Id = U.U_Id where  P.Cat_Id = {Category} and U.U_Id = {U_id}";
            return db.ExecuteQuery(commandText);
        }
    }
}
