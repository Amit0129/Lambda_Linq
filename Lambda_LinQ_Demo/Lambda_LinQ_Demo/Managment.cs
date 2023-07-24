using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public void Productreview(List<ProductReview> product)
        {
            var result = product.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            var record = from prod in product where (prod.ProductID == 1 || prod.ProductID == 4 || prod.ProductID == 9) && prod.Rating>3 select prod;
            Console.WriteLine("Using Lambda");
            Display(result);
            Console.WriteLine("Using LinQ");
            Display(record);
           
        }
        public void CountProduct(List<ProductReview> product)
        {
            Console.WriteLine("Using Lamda");
            var result = product.GroupBy(x => x.ProductID);
            foreach (var pro in result)
            {
                Console.WriteLine("Product Id :"+pro.Key+" No Of Time :"+pro.Count());
            }
            Console.WriteLine("Using LinQ");
            var record = product.GroupBy(x=>x.ProductID).Select(x => new {ProductID = x.Key, Count = x.Count()});
            foreach (var pro in record)
            {
                Console.WriteLine($"Product Id = {pro.ProductID} Count = {pro.Count}");
            }
        }
        public void ProductIdReview(List<ProductReview> product)
        {
            Console.WriteLine("Using Lamda");
            var result = product.Select(x => new { x.ProductID, x.Review });
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductID+" "+item.Review);
            }
            Console.WriteLine("Using LinQ");
            var records = from record in product select new {record.ProductID, record.Review };
            foreach (var prod in records)
            {
                Console.WriteLine($"Product Id : {prod.ProductID}  ; Product Review : {prod.Review}");
            }
        }
        public void ProductReviewSkipTop5(List<ProductReview> product)
        {
            var result = product.OrderByDescending(x => x.Rating).Skip(5);
            Display(result);
            Console.WriteLine("Using LinQ");
            var records = (from prod in product select prod).Skip(5);
            Display(records);

        }
        public void RetriveOnlyProductIdReview(List<ProductReview> product)
        {
            Console.WriteLine("Using Lamda");
            var result = product.Select(x => new { x.ProductID, x.Review });
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductID + " " + item.Review);
            }
            Console.WriteLine("Using LinQ");
            var records = from record in product select new { record.ProductID, record.Review };
            foreach (var prod in records)
            {
                Console.WriteLine($"Product Id : {prod.ProductID}  ; Product Review : {prod.Review}");
            }
        }
        public void Display(IEnumerable<ProductReview> result)
        {
            foreach (var prod in result)
            {
                Console.WriteLine($"Product Id : {prod.ProductID} ; UserId : {prod.UserID} ; Rating : {prod.Rating} ; Review : {prod.Review} ; IsLike : {prod.IsLike}");
            }
        }
    }
}
