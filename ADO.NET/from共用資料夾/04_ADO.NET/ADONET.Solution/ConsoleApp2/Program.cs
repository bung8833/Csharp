using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var category = new Category();
            category.Id = 1;
            category.Name = "XX";
            category.DisplayOrder = 10;

            var category2 = new Category{
                Id=1, 
                Name="XX", 
                DisplayOrder=10 
            };
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
