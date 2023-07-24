namespace Lambda_LinQ_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Managment managment = new Managment();
            bool check = true;
            List<ProductReview> products = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "VeryGood", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 5, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 4, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 3, Rating = 5, Review = "VeryGood", IsLike = true },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 6, UserID = 2, Rating = 1, Review = "VeryBad", IsLike = false },
                new ProductReview() { ProductID = 7, UserID = 3, Rating = 5, Review = "VeryGood", IsLike = true },
                new ProductReview() { ProductID = 8, UserID = 4, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 9, UserID = 5, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 10, UserID = 6, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 11, UserID = 9, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 12, UserID = 4, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 13, UserID = 3, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 9, Rating = 1, Review = "VeryBad", IsLike = false },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 16, UserID = 2, Rating = 5, Review = "VeryGood", IsLike = true },
                new ProductReview() { ProductID = 17, UserID = 3, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 18, UserID = 4, Rating = 1, Review = "VeryBad", IsLike = true },
                new ProductReview() { ProductID = 19, UserID = 5, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductID = 20, UserID = 6, Rating = 1, Review = "VeryBad", IsLike = false },
                new ProductReview() { ProductID = 21, UserID = 9, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 23, UserID = 4, Rating = 1, Review = "VeryBad", IsLike = false },
                new ProductReview() { ProductID = 23, UserID = 3, Rating = 5, Review = "VeryGood", IsLike = true },
                new ProductReview() { ProductID = 23, UserID = 2, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 23, UserID = 1, Rating = 4, Review = "Good", IsLike = true }
            };
            while (check)
            {
                Console.WriteLine("1.Retrieve Top Three record");
                Console.WriteLine("2. Retrine top reating product with Product Id 1,4,9");
                Console.WriteLine("3. For product Count");
                Console.WriteLine("4. For product And its review");
                Console.WriteLine("5. Skip top 5 record from list and show it");
                Console.WriteLine("6. Retrive only product And its review");
                Console.WriteLine("0. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        check = false;
                        break;
                    case 1:
                        managment.TopRecord(products);
                        break;
                    case 2:
                        managment.Productreview(products);
                        break;
                    case 3:
                        managment.CountProduct(products);
                        break;
                    case 4:
                        managment.ProductIdReview(products);
                        break;
                    case 5:
                        managment.ProductReviewSkipTop5(products);
                        break;
                    case 6:
                        managment.RetriveOnlyProductIdReview(products);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}