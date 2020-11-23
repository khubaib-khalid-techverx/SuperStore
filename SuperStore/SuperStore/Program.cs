using System.Collections.Generic;
using System.Linq;
using System;
namespace SuperStore
{
    class Program
    {
        static void Main(string[] args)
        {
           var temp= new Inventory();
            Product product = new Product() { Id = 2, Name = "KeyBoard", Price=100 , Total=3 };
            temp.addStock(product);
            temp.stockReport();
            temp.updateStock(new Product { Name = "abc" }, 1);
            temp.stockReport();
            Console.ReadLine();
        }
    }

  
    class Inventory
    {
        private List<Product> _product { get; set; }

        public Inventory()
        {
            _product = new List<Product>();
            _product.Add(new Product
            {
                Id = 1,
                Name = "temp"
            });
        }

        public void addStock(Product product)
        {
            _product.Add(product);
        }
        public void saleStock(int productId)
        {
            var product = _product.FirstOrDefault(x => x.Id == productId);
            _product.Remove(product);
        }
        public void updateStock(Product product,int productId)
        {
           var response=_product.FirstOrDefault(x => x.Id == productId);
            response.Name = product.Name;
        }
        public void stockReport()
        {
            foreach (var item in _product)
            {
                Console.WriteLine( $"Product Name {item.ProductCode}  { item.Name} ");
            }
        }

        
        //sale
        //add new stock
        //new 
        //update
        //stock report
        //check stock avilable or not 

    }
}
