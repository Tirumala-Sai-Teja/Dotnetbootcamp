using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assinment
{
    internal class Solution

    {

        public static void Main(string[] args)
        {
            int[] numbers = { 101, 2, 3, 200, 1001, 900 };
            Console.WriteLine("Task 1:");
            Console.WriteLine();
            Console.WriteLine();
            var cubes = from i in numbers
                        where i > 100  && i < 1000
                         select i*i*i;
            foreach(var i in cubes){

                Console.WriteLine(i);
                }
            Console.WriteLine();
           // Console.WriteLine("Task 2:");
            //Console.WriteLine();
            //List<string> players = new List<string> { "India","Chicago","China","Korea","japan","Russia","Mexico","India","Uganda","Japan","korea","Russia" };
            //var teams = ;\
            Console.WriteLine();
;            List<Order> orders = new List<Order>()
            {
                new Order(){item_name="mouse     ",order_id=1,date= DateTime.Parse("12.02.2020"),quantity=10 },

                new Order(){item_name="pendrive",order_id=2,date= DateTime.Parse("12.02.2021"),quantity=8 },

                new Order(){item_name="hard-disk",order_id=3,date= DateTime.Parse("12.02.2022"),quantity=5 },

                new Order(){item_name="ssd      ",order_id=4,date= DateTime.Parse("12.03.2021"),quantity=10 },

                 new Order(){item_name="power-bank",order_id=5,date= DateTime.Parse("10.02.2021"),quantity=9 },

                 new Order(){item_name="mouse     ",order_id=6,date= DateTime.Parse("04.20.2020"),quantity=3 },

                 new Order(){item_name="pendrive",order_id=7,date= DateTime.Parse("04.21.2022"),quantity=5 },

                 new Order(){item_name="hard-disk",order_id=8,date= DateTime.Parse("07.28.2019"),quantity=7 },

                 new Order(){item_name="ssd      ",order_id=9,date= DateTime.Parse("07.04.2019"),quantity=15 },

                 new Order(){item_name="power-bank",order_id=10,date= DateTime.Parse("03.05.2020"),quantity=20 },


                };
            Console.WriteLine("Task3");
            List<Order> list2 = orders.OrderByDescending(order => order.date).ThenByDescending(order => order.quantity).ToList();
            Console.WriteLine("ID \t Item-Name \t Date \t\t Quantity");
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.WriteLine($"{item.order_id}\t{item.item_name}\t{item.date.ToString("dd/MM/yyyy")}\t     {item.quantity}");

            }
            Console.WriteLine();
            Console.WriteLine("task4");
            Console.WriteLine();
            var task4 = orders.OrderByDescending(order=>order.date).GroupBy(order => order.date.ToString("MMM"));
            foreach(var items in task4)
            {
                Console.WriteLine("Orders On" + "  "+ items.Key );
                Console.WriteLine();
                Console.WriteLine("ID \t Item-Name \t Date \t\t Quantity");
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.order_id}\t{item.item_name}\t{item.date.ToString("dd/MM/yyyy")}\t     {item.quantity}");

                }


            }
            List<Item> task5 = new List<Item>()
            {
                new Item {item_name="mouse     ",price=500},
                new Item {item_name="pendrive",price=900},
             new Item {item_name="hard-disk",price=1500},
              new Item {item_name="ssd      ",price=600},
               new Item {item_name="power-bank",price=1100},

            };
            Console.WriteLine();
            Console.WriteLine("Task 5");
            Console.WriteLine();
            var t5 = from ord in orders
                     join itm in task5
                     on ord.item_name equals itm.item_name
                      into a
                     from b in a.DefaultIfEmpty(new Item())
                     select new
                     {
                         id = ord.order_id,
                         name=ord.item_name,
                         date=ord.date,
                         qt=ord.quantity,
                         price=b.price

                     };
            var t5result = t5.OrderByDescending(r => r.date).GroupBy(r => r.date.ToString("MMM"));
          

            foreach (var ritem in t5result)
            {
                Console.WriteLine("Orders On" + "  " + ritem.Key);
                Console.WriteLine();

                Console.WriteLine("ID \t Item-Name \t Date \t\t Quantity \t Total Price");
                Console.WriteLine();
                foreach (var r in ritem)
                {
                    Console.WriteLine(r.id + "\t" + r.name + "\t" + r.date.ToString("dd/MM/yyyy") + "\t     " + r.qt + "\t          " + r.price * r.qt);
                }


            }

            Console.WriteLine();
            Console.WriteLine("Task 6");
            Console.WriteLine();

          

            var res = from ord in orders
                         join itm in task5
                         on ord.item_name equals itm.item_name
                         into a
                         from b in a.DefaultIfEmpty(new Item())
                         select new
                         {
                             ord.item_name,
                             ord.order_id,
                             ord.date,
                             ord.quantity,
                             b.price
                         };
            var result = res.OrderByDescending(r => r.date).GroupBy(r => r.date.ToString("MMM"));
           
          
            foreach (var ritem in result)
            {
                Console.WriteLine("Orders On" + "  " + ritem.Key);
                Console.WriteLine();
     
                Console.WriteLine("ID \t Item-Name \t Date \t\t Quantity \t Total Price");
                Console.WriteLine();
                foreach (var r in ritem)
                {
                    Console.WriteLine(r.order_id + "\t" + r.item_name + "\t" + r.date.ToString("dd/MM/yyyy") + "\t     " + r.quantity + "\t          " + r.price * r.quantity);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Task 7");
            Console.WriteLine();
            Console.WriteLine("part A");
            Console.WriteLine("-----------------------------------------------------------------------");
            bool isgreater = false;
            isgreater = orders.All(ord => ord.quantity > 0);
            if (isgreater)
            {
                Console.WriteLine("All orders have quantity greater than 0");
            }
            else
            {
                Console.WriteLine("some of orders have quantity less than 0");

            }
            Console.WriteLine();
            Console.WriteLine("part B");
            Console.WriteLine("-----------------------------------------------------------------------");
            
            /*var highqt = orders.Max(ord => ord.quantity);
            Console.WriteLine(highqt);*/
            var hqt = orders.Aggregate((q1, q2) => q1.quantity > q2.quantity ? q1 : q2);
            Console.WriteLine(hqt.item_name + " " + hqt.quantity);
            Console.WriteLine();
            Console.WriteLine("part C");
            Console.WriteLine("-----------------------------------------------------------------------");
            DateTime dt = DateTime.Parse("01/01/2022");
            var ordbjan = orders.Where(o => o.date<dt);
            Console.WriteLine("ID \t Item-Name \t Date \t\t Quantity");
            Console.WriteLine();
            foreach (var item in ordbjan)
            {
                Console.WriteLine($"{item.order_id}\t{item.item_name}\t{item.date.ToString("dd/MM/yyyy")}\t     {item.quantity}");

            }
            //Console.WriteLine();
            //Console.WriteLine("Task 8");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 9");
            Console.WriteLine();
            Console.WriteLine("part A");
            Console.WriteLine("-----------------------------------------------------------------------");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = arr.Count(a => a % 2 == 0);
            var evenList = arr.Where(a => a % 2 == 0);
            Console.WriteLine("total number of even numbers in the given array is: "+even);
            foreach(int a in evenList)
            {
                Console.Write(+a + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("part B");
            Console.WriteLine("-----------------------------------------------------------------------");

            var task9 = orders.GroupBy(o => o.item_name);
            
            int mnqt = -999;
            string mnitem = "";
            Console.WriteLine("Item_Name \t Quantity ");
            Console.WriteLine();
            foreach(var t9 in task9)
            {
                var sm = t9.Sum(t => t.quantity);
                Console.WriteLine($"{t9.Key}\t{sm}");
                if (mnqt < sm)
                {
                    mnqt = sm;
                    mnitem = t9.Key;
                }

            }

            Console.WriteLine($"Maximum quantities ordered is {mnqt} and the item is {mnitem}");

        }

    }
}

