using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVC_Odev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Odev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static List<Customer> customers = new List<Customer>(){
            new Customer{ Id="ALFKI",CompanyName="Alfreds Futterkiste",CustomerName="Maria Anders",CustomerPhone="030-0074321",CustomerTitle="Sales Representative"},
            new Customer{ Id="ANATR",CompanyName="Ana Trujillo Emparedados y helados",CustomerName="Ana Trujillo",CustomerPhone="(5) 555-4729",CustomerTitle="Owner"},
            new Customer{ Id="ANTON",CompanyName="Antonio Moreno Taquería",CustomerName="Antonio Moreno",CustomerPhone="(5) 555-4722",CustomerTitle="Order Administrator"},
            new Customer{ Id="AROUT",CompanyName="Around the Horn",CustomerName="Thomas Hardy",CustomerPhone="(171) 555-7788",CustomerTitle="Owner"},
            new Customer{ Id="BERGS",CompanyName="Berglunds snabbköp",CustomerName="Christina Berglund",CustomerPhone="0921-12 34 65",CustomerTitle="Owner"}
        };

        public static List<Employee> employees = new List<Employee>() {
            new Employee{Id=1, EmployeeFirstName="Nancy",EmployeeLastName="Davolio",EmployeePhone="(206) 555-9857",EmployeeTitle="Sales Representative"},
            new Employee{Id=2, EmployeeFirstName="Andrew",EmployeeLastName="Fuller",EmployeePhone="(206) 555-9482",EmployeeTitle="Vice President, Sales"},
            new Employee{Id=3, EmployeeFirstName="Janet",EmployeeLastName="Leverling",EmployeePhone="(206) 555-3412",EmployeeTitle="Sales Representative"},
            new Employee{Id=4, EmployeeFirstName="Margaret",EmployeeLastName="Peacock",EmployeePhone="(206) 555-8122",EmployeeTitle="Sales Representative"},
            new Employee{Id=5, EmployeeFirstName="Steven",EmployeeLastName="Buchanan",EmployeePhone="(71) 555-4848",EmployeeTitle="Sales Manager"}
        };

        public static List<Product> products = new List<Product>()
        {
                new Product{Id=1,ProductName="Konbu",UnitPrice=6.000m,UnitsInStock=24},
                new Product{Id=2,ProductName="Tofu",UnitPrice=23.250m,UnitsInStock=35},
                new Product{Id=3,ProductName="Pavlova",UnitPrice=17.450m,UnitsInStock=29},
                new Product{Id=4,ProductName="Geitost",UnitPrice=25.000m,UnitsInStock=112},
                new Product{Id=5,ProductName="Chang",UnitPrice=19.000m,UnitsInStock=17},
                new Product{Id=6,ProductName="Ikura",UnitPrice=31.000m,UnitsInStock=31}
        };

        public static List<Order> orders = new List<Order>()
        {
            new Order { Id = 1, CustomerID=1, Freight=20.5m, OrderDate=new DateTime(2023,10,10), ShipAdress="st. saint street/Kabul/Afghanistan", ShipVia="Aras Kargo"},
            new Order { Id = 2, CustomerID=1, Freight=2040.35m, OrderDate=new DateTime(2023,12,04), ShipAdress="st. saint street/Kabul/Afghanistan", ShipVia="Sürat Kargo"},
            new Order { Id = 3, CustomerID=2, Freight=600m, OrderDate=new DateTime(2023,12,04), ShipAdress="st. saint street/Kabul/Afghanistan", ShipVia="Sürat Kargo"},
        };

        public static List<SepetProduct> sepet = new List<SepetProduct>();

        public static void SepetOlustur()
        {
            SepetProduct sepetUrun = new SepetProduct();
            foreach (Product product in products)
            {
                sepetUrun.Id = product.Id;
                sepetUrun.Name = product.ProductName;
                sepetUrun.Price = product.UnitPrice;
                sepetUrun.Amount = 0;
                sepet.Add(sepetUrun);
                sepetUrun = new SepetProduct();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
