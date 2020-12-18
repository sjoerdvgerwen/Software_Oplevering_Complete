using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Entity;
using Warehouse.Application.Interfaces;

namespace Warehouse.Database.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlConnection _con;


        // ??
        public ProductRepository(MySqlConnection con)
        {
            _con = con;
        }

        public async Task<Product> AddProduct (Product product)
        {
            await _con.OpenAsync();

            string query = "INSERT INTO Product (ProductID, ProductName, ProductDescription) VALUES(@Id, @Name, @Des)";
            var command = new MySqlCommand(query, _con);

            command.Parameters.AddWithValue("@Id", product.ProductID);
            command.Parameters.AddWithValue("@Name", product.ProductName);
            command.Parameters.AddWithValue("@Des", product.ProductDescription);

            command.ExecuteNonQuery();

            await _con.CloseAsync();

            return product;
        }
    }
}
