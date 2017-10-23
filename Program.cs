using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContex())
            {
				var categories = db.Categories;
                var orders = db.Orders;
                var oD = db.orderDetails;

                Console.WriteLine("__________________________________________________________________________________");

                //Guestion 1.
                //foreach (var j in categories.Where(c => c.Id == 7)){
                //    Console.WriteLine(j.Id + "|\t|" + j.Name + "\t\t|" + j.Description);
                //}

                //foreach (var i in oD){
                //    Console.WriteLine(i.OrderId + i.ProductId + i.UnitPrice + i.Quantity + i.Discount);
                //}

				//Question 10: ADD new category
				/*var addCategory = new Category
				{
					Name = "New object",
					Description = "Testing"
				};

				db.SaveChanges();
				db.Categories.Add(addCategory);*/

                //QUESTION 11: UPDATE
				/*var updatedCategory = categories.FirstOrDefault(c => c.Id == 19);
				updatedCategory.Name = "RANDOM";
				db.SaveChanges();*/

                //TEST 1: trying to change all data with a specific string --> and id.
				//List<int> list = new List<int>();

                /*foreach (var n in categories
                         .Where(m => m.Name == "Test")){
                    list.Add(n.Id);
                }*/

                //TEST 1.A
                //foreach (int j in list)
                //{
                //    var updatedTest = categories.FirstOrDefault(c => c.Id == j);
                //    updatedTest.Name = "Test";
                //    db.SaveChanges();
                //}

                //TEST 1.B
                //TEST: deleting more than one row. by id.
                /*foreach (int j in list)
                {
                    var deletedRow = categories.FirstOrDefault(c => c.Id == j);
                    db.Categories.Remove(deletedRow);
                    db.SaveChanges();
                }*/
	
                    // QUSTION 9: write all data within category.
                /*foreach (var category in categories)
				{
					Console.WriteLine(category.Id + "|\t|" + category.Name + "\t\t|" + category.Description);
				}*/
			}

        }
    }
}
