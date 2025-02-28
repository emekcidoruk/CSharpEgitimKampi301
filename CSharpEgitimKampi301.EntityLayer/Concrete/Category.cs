using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryID { get; set; } // Birincil anahtar olduğunu ve ototmatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı olmalı, sonuna ID getirilmeli
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } // Bir category'nin içinde birden fazla ürün olabileceği için "Products" yazdık


    }
}
/*
 
 Field-Variable-Property

----------------------------------

int x; --> Field

----------------------------------

int y { get; set; } --> Property,

----------------------------------

void test()
{
    int z; --> Verable
}
 
 */
