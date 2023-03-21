using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Mercado.Models;

namespace Mercado.Repositories
{
    public class CategoryRepository
    {
        private string CONNECTION_STRING;
        public CategoryRepository (string CONNECTION_STRING)
        => this.CONNECTION_STRING = CONNECTION_STRING;

        public Category CreateCategory(string name)
        {
            var Category = new Category();
            Category.Name = name;

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                Category.Id = (int) connection.Insert<Category>(Category);
                connection.Close();
                return Category;
                
            }
        }
 
    }
}