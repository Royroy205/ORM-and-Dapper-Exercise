using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

#region Department Section
//var departmentRepo = new DapperDepartmentRepository(conn);

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments) 
//{
//   Console.WriteLine(department.DepartmentID);
//    Console.WriteLine(department.Name);
//      Console.WriteLine();
//    Console.WriteLine();


//}
#endregion

var productRepo = new DapperProductRepository(conn);

var products = productRepo.GetAllProducts();
foreach (var product in products) 
{ 
    Console.WriteLine(product.Name);
    Console.WriteLine(product.ProductID);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.CategoryID);
    Console.WriteLine(product.OnSale);
    Console.WriteLine(product.StockLevel);
    Console.WriteLine();
    Console.WriteLine();

}  