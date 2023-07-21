using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_LinQ_Demo
{
    public class Managment
    {
        public void TopRecord(List<ProductReview> reviews)
        {
            var result = reviews.OrderByDescending(x=>x.Rating).Take(3);
            var record = (from product in reviews orderby product.Rating descending select product).Take(3);
            Console.WriteLine("Using Lambda");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductID+" "+prod.UserID+" "+prod.Rating+" "+prod.Review+" "+prod.IsLike);
            }
            Console.WriteLine("Using LinQ");
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductID + " " + prod.UserID + " " + prod.Rating + " " + prod.Review + " " + prod.IsLike);
            }
        }
    }
}
