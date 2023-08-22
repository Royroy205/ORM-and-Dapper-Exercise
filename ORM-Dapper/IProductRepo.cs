using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IProductRepo
    {
      public IEnumerable<Product> GetProducts();

        public void InsertProduct(string name, double price, int categoryID );
    
    
    }
}
