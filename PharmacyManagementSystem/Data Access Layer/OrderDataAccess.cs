using PharmacyManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Data_Access_Layer
{
    class OrderDataAccess:DataAccess
    {
        public List<Order> ShowProducts()
        {
            string sql = "SELECT * FROM Orders";
            SqlDataReader reader = this.GetData(sql);

            List<Order> products = new List<Order>();
            while (reader.Read())
            {
                Order product = new Order();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = (int)reader["Price"];
                product.Quantity = (int)reader["Quantity"];
                product.CustomerName = reader["CustomerName"].ToString();
                products.Add(product);
            }
            return products;
        }

        public Order ShowProductsById(int productId)
        {
            string sql = "SELECT * FROM Orders WHERE ProductId="+productId;
            SqlDataReader reader = this.GetData(sql);

            if (reader.HasRows)
            {
                reader.Read();
                Order product = new Order();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = (int)reader["Price"];
                product.Quantity = (int)reader["Quantity"];
                product.CustomerName = reader["CustomerName"].ToString(); 
                return product;
            }
            else
                return null;          
        }

        public List<Order> ShowProductsByName(string search)
        {
            string sql = "SELECT * FROM Orders WHERE ProductName LIKE '" + search + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Order> products = new List<Order>();
            while (reader.Read())
            {
                Order product = new Order();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = (int)reader["Price"];
                product.Quantity = (int)reader["Quantity"];
                product.CustomerName = reader["CustomerName"].ToString();
                products.Add(product);
            }
            return products;
        } 

        public bool CreateProduct(string productName, int price, int quantity,String customerName)
        {
            string sql = "INSERT INTO Orders(ProductName,Price,Quantity,CustomerName) VALUES('" + productName + "'," + price + "," + quantity + ",'" + customerName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateProduct(int productId, string productName, int price, int quantity)
        {
            string sql = "UPDATE Orders SET ProductName='" + productName + "',Price=" + price + ",Quantity=" + quantity + "WHERE ProductId=" + productId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteProduct(int productId)
        {
            string sql = "DELETE FROM Orders WHERE ProductId=" + productId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }        

        public List<Order> ShowCustomerOrderByName(string search)
        {
            string sql = "SELECT * FROM Orders WHERE CustomerName LIKE '" + search + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Order> customers = new List<Order>();
            while (reader.Read())
            {
                Order customer = new Order();
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.ProductId = (int)reader["ProductId"];
                customer.Price = (int)reader["Price"];
                customer.ProductName = reader["ProductName"].ToString();
                customer.Quantity = (int)reader["Quantity"];

                customers.Add(customer);
            }
            return customers;
        }
    }
}
