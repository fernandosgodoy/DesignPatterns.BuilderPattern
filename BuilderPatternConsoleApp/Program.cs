using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BuilderPatternConsoleApp.FastFoodOrderBuild
{

    /// <summary>
    /// Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new MenuDirector();

            Console.WriteLine("Welcome to Delivery Menu. Let's start with your order.");

            var builder = new MenuBuilder();
            director.Builder = builder;

            Console.WriteLine("Please, select the option: ");
            Console.WriteLine("1- BigMac Combo");
            Console.WriteLine("2- BigTasty Combo");
            Console.WriteLine("3- Customized order");

            Console.WriteLine("Type the number:");
            string entry = null;
            while(entry == null)
                entry = Console.ReadLine();

            Console.WriteLine("Staring your order");
            var orderInfo = new Menu();
            if (entry == "1")
            {
                director.BuildBigMacMenuDeskWithdraw();
                orderInfo = builder.Get();
            }
            else if (entry == "2")
            {
                director.BuildBigTastyMenuDeskWithdraw();
                orderInfo = builder.Get();
            }
            else if(entry == "3")
            {
                Console.WriteLine("Choose the burguer: 1- BigMac; 2- McChicken; 3- McFish; 4- BigTasty; ");
                string burguer = null;
                while (burguer == null)
                    burguer = Console.ReadLine();

                Console.WriteLine("Additional? 1- Yes; 2- No; ");
                string hasAdditional = null;
                while (hasAdditional == null)
                    hasAdditional = Console.ReadLine();

                Console.WriteLine(@"Choose the Additional: 
                    0- Exit; 
                    1- Fries; 
                    2- VanilaCone
                    3- ChocolateShake,
                    4- VanilaShake,
                    5- StrawberryShake,
                    6- BakedApplePie,
                    7- McFlurryWithOreo,
                    8- CocaCola
                ");

                var additionalItems = new List<MenuAdditional>();
                if (hasAdditional != null)
                {
                    string additionalOption = null;
                    while (additionalOption == null)
                    {
                        if (additionalOption == "0")
                            break;

                        additionalOption = Console.ReadLine();
                        additionalItems.Add(new MenuAdditional()
                        {
                            AdditionalItem = Convert.ToInt32(additionalOption),
                            Quantity = 1
                        });
                    }
                }

                Console.WriteLine("Delivery? 1- Yes; 2- No; ");
                string isDelivery = null;
                while (isDelivery == null)
                    isDelivery = Console.ReadLine();

                Console.WriteLine("Ketchup? 1- Yes; 2- No; ");
                string wannaKetchup = null;
                while (wannaKetchup == null)
                    wannaKetchup = Console.ReadLine();

                Console.WriteLine("Special thing? Type: ");
                string specialMessage = null;
                while (specialMessage == null)
                    specialMessage = Console.ReadLine();

                director.BuildPersonalizedMenu(
                    (ComboMenuType)Convert.ToInt32(burguer),    //is it really necessary? ==> for now, yeah! ;)
                    additionalItems,
                    (isDelivery == "1"),
                    (wannaKetchup == "1"),
                    specialMessage
                );
                orderInfo = builder.Get();
            }

            Console.WriteLine($"Order done: {JsonConvert.SerializeObject(orderInfo)}");
            Console.Read();
        }
    }
}
