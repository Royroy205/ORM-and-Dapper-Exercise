using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class ProductRepo 
    {
        private readonly IDbConnection connection;

        public ProductRepo(IDbConnection _connection) 
        { 
           _connection = connection;
        }
       
        public IEnumerable<Product> GetProducts() 
        {
            return _connection.Query<Product>("SELECT * FROM Products;");
        
        }
    
        public void InsertProduct(string name, double price, int categoryID) 
        { 
        
        
        }
    }
}
