using System;
using System.Collections.Generic;
using System.IO;

namespace FilipinoBakery
{
    class Program
    {
        public static void Main(string[] args)
        {
            int z = 0;
            int o = 0;
            string FilePath = @"C:\BakeryFilipino\";
            Directory.CreateDirectory(FilePath);
            string[] Slot1 = File.ReadAllLines(FilePath + @"slot1.txt");
            string[] Slot2 = File.ReadAllLines(FilePath + @"slot2.txt");
            string[] Slot3 = File.ReadAllLines(FilePath + @"slot3.txt");
            string[] Autosave = File.ReadAllLines(FilePath + @"Autosave.txt");
            bool AlreadyMadeMonay = false;
            bool AlreadyMadePanDeCoco = false;
            bool AlreadyMadePuto = false;
            Random rnd = new Random();
            double KiloOfFlour = 15.8;
            double Peso = 150;
            double MilkLitter = 5;
            double HowMuchPastriesUHave = 11;
            double Eggs = 5; // i made them double to make it formatexception, gosh i could have made it integer, i'm a dummy
            int MeralcoGameOver = 0;
            int WaterGameOver = 0;
            int ShopUpkeepOver = 0;
            bool DoesOwnRiceCakeRecipe = false;
            bool DoesOwnMonayRecipe = false;
            bool DoesOwnPanDeCocoRecipe = false;
            bool DoesHaveCalculator = false;

            List<string> Pastries = new List<string>();

            Pastries.Add("Donuts");
            Pastries.Add("Pandesal");
            Pastries.Add("Breadstick");
            Pastries.Add("Crinkles");
            Pastries.Add("empandas");

            List<double> PastriesPrice = new List<double>();

            PastriesPrice.Add(15);
            PastriesPrice.Add(10);
            PastriesPrice.Add(13);
            PastriesPrice.Add(10);
            PastriesPrice.Add(13);

            Console.WriteLine("Let's start! Hit enter ot type anything to start!, Type Tutorial to get a guideline\nTO LOAD A SAVE FILE, TYPE SAVE");
            string TutorialOrNo = Console.ReadLine()!; TutorialOrNo = TutorialOrNo.ToUpper();

            if (TutorialOrNo.Contains("TUTOR"))
            {
                string[] TutorDRY = { "Welcome To This Game", "1. For each 5 customers u process, you get asked if u want to shop or view stuff",
                "2. You Can buy recipes and make new items out of it", "3. At the same time  u have to manage bills and try to not go into game over ending\n"};
                for (int v = 0; v < 4; v++) { Console.WriteLine(TutorDRY[v]); }
                Console.WriteLine("Welcome To Filipino bakery : The Choice of yours Of - Proletriat Or Burgoeisis");
                Console.WriteLine("If the choices of yours is proletriat u can use your revenue to pay bills and survive");
                Console.WriteLine("Stereotypical Capitalism. Otherwise if u were to be a burgoeisis U Can Invest in means");
                Console.WriteLine("Free market meaning to invest in recipes and squezze as much profit to expand\nYour revenue further more");
                Console.WriteLine("Try to survive while keeping your choice of best\n Hit enter or anything to proceed");
                Console.ReadKey();
            }
            else if (TutorialOrNo.Equals("SAVE", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Which One To Load?\nSlot 1\nSlot 2\nSlot 3\nAutosave\ntype slots without spacing");
                string WhichSlot = Console.ReadLine()!;
                switch (WhichSlot)
                {
                    case string when WhichSlot.Equals("slot1", StringComparison.OrdinalIgnoreCase): // war crimes against D.R.Y
                        Console.WriteLine("Loading Content, Please Wait");
                        AlreadyMadeMonay = Convert.ToBoolean(Slot1[1]);
                        AlreadyMadePanDeCoco = Convert.ToBoolean(Slot1[3]);
                        AlreadyMadePuto = Convert.ToBoolean(Slot1[5]);
                        KiloOfFlour = Convert.ToDouble(Slot1[7]);
                        Peso = Convert.ToDouble(Slot1[9]);
                        MilkLitter = Convert.ToDouble(Slot1[11]);
                        HowMuchPastriesUHave = Convert.ToDouble(Slot1[13]);
                        Eggs = Convert.ToDouble(Slot1[15]);
                        MeralcoGameOver = Convert.ToInt32(Slot1[17]);
                        WaterGameOver = Convert.ToInt32(Slot1[19]);
                        ShopUpkeepOver = Convert.ToInt32(Slot1[21]);
                        DoesOwnRiceCakeRecipe = Convert.ToBoolean(Slot1[23]);
                        DoesOwnMonayRecipe = Convert.ToBoolean(Slot1[25]);
                        DoesOwnPanDeCocoRecipe = Convert.ToBoolean(Slot1[27]);
                        DoesHaveCalculator = Convert.ToBoolean(Slot1[29]);
                        z = Convert.ToInt32(Slot1[31]);
                        o = Convert.ToInt32(Slot1[33]);
                        break;
                    case string when WhichSlot.Equals("slot2", StringComparison.OrdinalIgnoreCase):
                        Console.WriteLine("Loading Content, Please Wait");
                        AlreadyMadeMonay = Convert.ToBoolean(Slot2[1]);
                        AlreadyMadePanDeCoco = Convert.ToBoolean(Slot2[3]);
                        AlreadyMadePuto = Convert.ToBoolean(Slot2[5]);
                        KiloOfFlour = Convert.ToDouble(Slot2[7]);
                        Peso = Convert.ToDouble(Slot2[9]);
                        MilkLitter = Convert.ToDouble(Slot2[11]);
                        HowMuchPastriesUHave = Convert.ToDouble(Slot2[13]);
                        Eggs = Convert.ToDouble(Slot2[15]);
                        MeralcoGameOver = Convert.ToInt32(Slot2[17]);
                        WaterGameOver = Convert.ToInt32(Slot2[19]);
                        ShopUpkeepOver = Convert.ToInt32(Slot2[21]);
                        DoesOwnRiceCakeRecipe = Convert.ToBoolean(Slot2[23]);
                        DoesOwnMonayRecipe = Convert.ToBoolean(Slot2[25]);
                        DoesOwnPanDeCocoRecipe = Convert.ToBoolean(Slot2[27]);
                        DoesHaveCalculator = Convert.ToBoolean(Slot2[29]);
                        z = Convert.ToInt32(Slot2[31]);
                        o = Convert.ToInt32(Slot2[33]);
                        break;
                    case string when WhichSlot.Equals("slot3", StringComparison.OrdinalIgnoreCase): // war crimes against D.R.Y
                        Console.WriteLine("Loading Content, Please Wait");
                        AlreadyMadeMonay = Convert.ToBoolean(Slot3[1]);
                        AlreadyMadePanDeCoco = Convert.ToBoolean(Slot3[3]);
                        AlreadyMadePuto = Convert.ToBoolean(Slot3[5]);
                        KiloOfFlour = Convert.ToDouble(Slot3[7]);
                        Peso = Convert.ToDouble(Slot3[9]);
                        MilkLitter = Convert.ToDouble(Slot3[11]);
                        HowMuchPastriesUHave = Convert.ToDouble(Slot3[13]);
                        Eggs = Convert.ToDouble(Slot3[15]);
                        MeralcoGameOver = Convert.ToInt32(Slot3[17]);
                        WaterGameOver = Convert.ToInt32(Slot3[19]);
                        ShopUpkeepOver = Convert.ToInt32(Slot3[21]);
                        DoesOwnRiceCakeRecipe = Convert.ToBoolean(Slot3[23]);
                        DoesOwnMonayRecipe = Convert.ToBoolean(Slot3[25]);
                        DoesOwnPanDeCocoRecipe = Convert.ToBoolean(Slot3[27]);
                        DoesHaveCalculator = Convert.ToBoolean(Slot3[29]);
                        z = Convert.ToInt32(Slot3[31]);
                        o = Convert.ToInt32(Slot3[33]);
                        break;
                    case string when WhichSlot.Equals("autosave", StringComparison.OrdinalIgnoreCase): // war crimes against D.R.Y
                        Console.WriteLine("Loading Content, Please Wait");
                        AlreadyMadeMonay = Convert.ToBoolean(Autosave[1]);
                        AlreadyMadePanDeCoco = Convert.ToBoolean(Autosave[3]);
                        AlreadyMadePuto = Convert.ToBoolean(Autosave[5]);
                        KiloOfFlour = Convert.ToDouble(Autosave[7]);
                        Peso = Convert.ToDouble(Autosave[9]);
                        MilkLitter = Convert.ToDouble(Autosave[11]);
                        HowMuchPastriesUHave = Convert.ToDouble(Autosave[13]);
                        Eggs = Convert.ToDouble(Autosave[15]);
                        MeralcoGameOver = Convert.ToInt32(Autosave[17]);
                        WaterGameOver = Convert.ToInt32(Autosave[19]);
                        ShopUpkeepOver = Convert.ToInt32(Autosave[21]);
                        DoesOwnRiceCakeRecipe = Convert.ToBoolean(Autosave[23]);
                        DoesOwnMonayRecipe = Convert.ToBoolean(Autosave[25]);
                        DoesOwnPanDeCocoRecipe = Convert.ToBoolean(Autosave[27]);
                        DoesHaveCalculator = Convert.ToBoolean(Autosave[29]);
                        z = Convert.ToInt32(Autosave[31]);
                        o = Convert.ToInt32(Autosave[33]);
                        break;
                    default:
                        Console.WriteLine("Save file does not exist! sorry");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Okay!");
            }
            Console.WriteLine($"Balance : {Peso} Peso");
            while (true && MeralcoGameOver <= 3 && WaterGameOver <= 3 && ShopUpkeepOver <= 3)
            {
                int MeralInt = rnd.Next(55, 75);
                int WaterInt = rnd.Next(35, 45);
                int BakeInt = rnd.Next(30, 40);
                for (int i = o; i < 3; i++)
                {
                    for (int k = z; k < 5; k++)
                    {
                        z = 0;
                        o = 0;
                        string[] Request = { "Can I Buy", "Pabili Po.", "Magkano Si"};
                        string[] ThankYou = { "Maraming Salmat Po", "Thank You", "Salamat Po"};
                        int PastriesRandomizer = rnd.Next(0, Pastries.Count);
                        int DialougeRandomizer = rnd.Next(0, 3);
                        int KAV = rnd.Next(1, 4);
                        double HowMuchCustomerWannaBuy = Convert.ToDouble(KAV);
                        int WaitPlz = rnd.Next(2622, 3567);

                        if (HowMuchCustomerWannaBuy > HowMuchPastriesUHave)
                        {
                            Console.WriteLine($"Customer : {Request[DialougeRandomizer]} {HowMuchCustomerWannaBuy} {Pastries[PastriesRandomizer]}");
                            Thread.Sleep(314);
                            Console.WriteLine($"We Don't have that much, sorry!");
                            Console.WriteLine($"Now wait for another customer");
                            Thread.Sleep(WaitPlz);
                        }
                        else
                        {
                            double PriceGetter = PastriesPrice[PastriesRandomizer];
                            Console.WriteLine($"Customer : {Request[DialougeRandomizer]} {HowMuchCustomerWannaBuy} {Pastries[PastriesRandomizer]}");
                            Thread.Sleep(314);
                            Console.WriteLine("You have a customer! Guess how much you owe");
                            Console.WriteLine("Here is how much u owe based on the price list");
                            double Subex = 0; // I tried finding out why try variables are limited and cannot be used outside. So from what internet says i declared an variable
                            // with a ? operator and a null value
                            if (DoesHaveCalculator == true)
                            {
                                Console.WriteLine($"Calculated Total Price {PriceGetter * HowMuchCustomerWannaBuy}");
                            }
                            for (int X = 0; X < Pastries.Count; X++)
                            {
                                Console.WriteLine($"{Pastries[X]} : {PastriesPrice[X]}");
                            }
                            try
                            {
                                Subex = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Only Numbers Please");
                            }
                            double TotalPrice = PriceGetter * HowMuchCustomerWannaBuy;

                            while (Subex > TotalPrice)
                            {
                                Console.WriteLine("it's higher than estimated price! Guess it again");
                                try
                                {
                                    Subex = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Only Type Numbers");
                                }
                            }
                            while (Subex <= 0)
                            {
                                Console.WriteLine("Number is too low! Type anything higher than Zero");
                                Subex = Convert.ToDouble(Console.ReadLine());
                            }

                            if (Subex < TotalPrice) // Definelty not crimes against DRY
                            {
                                HowMuchPastriesUHave = HowMuchPastriesUHave - HowMuchCustomerWannaBuy;
                                Peso = Peso + Subex;
                                Console.WriteLine("You : Here's your stuff sir");
                                Console.WriteLine($"Customer : {ThankYou[DialougeRandomizer]}");
                                Console.WriteLine($"Balance : {Peso} Peso");
                                Console.WriteLine($"Your charged price was lower than Estimated Price");
                                Console.WriteLine($"Now wait for another customer");
                                Thread.Sleep(WaitPlz);
                            }
                            else
                            {
                                HowMuchPastriesUHave = HowMuchPastriesUHave - HowMuchCustomerWannaBuy;
                                Peso = Peso + TotalPrice;
                                Console.WriteLine("You : Here's your stuff sir");
                                Console.WriteLine($"Customer : {ThankYou[DialougeRandomizer]}");
                                Console.WriteLine($"Balance : {Peso} Peso");
                                Console.WriteLine($"Now wait for another customer");
                                Thread.Sleep(WaitPlz);
                            }
                        }

                        if (HowMuchPastriesUHave <= 0)
                        {
                            Console.WriteLine("You've ran out of Pastries, Consider refilling by typing Y");
                            string RefillOrNot = Console.ReadLine()!; RefillOrNot = RefillOrNot.ToUpper();

                            switch (RefillOrNot)
                            {
                                case "Y":
                                    if (Eggs >= 3 && KiloOfFlour >= 3 && MilkLitter >= 3)
                                    {
                                        Console.WriteLine("Let's start baking now! Let's wait some few seconds for it to be done");
                                        Thread.Sleep(8500);
                                        Eggs = Eggs - 3;
                                        KiloOfFlour = KiloOfFlour - 3;
                                        MilkLitter = MilkLitter - 3;
                                        HowMuchPastriesUHave += 10;
                                        Console.WriteLine("Reifllment costed 3 eggs, 3 kilo of flour, and 3 litters of milk. refillment Sucessful!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient Supplies to refill : Need 3 eggs, 3 kilo of flour, and 3 litters of milk");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Sales will drop aslong your Pastry supply is empty!");
                                    break;
                            }
                        }
                    }
                    string[] DRYSTUFF = { "WHAT DO YOU WANNA DO", "1. Buy New Recipe Or Buy Flour and supplies", 
                    "2. Overview of your nesscesites", "3. Supply Pastries by making", "4. Save Progress", "5. Nothing At All"};
                    for (int u = 0; u < 5; u++)
                    {
                        Console.WriteLine(DRYSTUFF[u]);
                    }
                    string Choice = Console.ReadLine()!; Choice = Choice.ToUpper();
                    
                    if (Choice.Contains("BUY") || Choice.Contains("1"))
                    {
                        string[] DRYSTUFFAGAIN = { "Please Pick Things To Buy", "1. Bag Of Flour : Only Refill Flour Supplies : Cost 50",
                        "2. Cartoon Of Milk : Only Refill Milk Supplies : Cost 45", "3. Recipe Of Pan De Coco : Sells For 35 : Cost 55", 
                        "4. Recipe Of Monay : Sells for 45 : Cost 65", "5. Puto Rice Cake : Sells For 25 : Cost 35", "6. Eggs : Only For FIlling Eggs : Cost 25",
                        "Calculator : Only for Finding Correct Total Price : Cost 5 Peso"};

                        for (int j = 0; j < 8; j++)
                        {
                            Console.WriteLine(DRYSTUFFAGAIN[j]);
                        }
                        string WhatWantToBuy = Console.ReadLine()!; WhatWantToBuy = WhatWantToBuy.ToUpper();

                        if (WhatWantToBuy.Contains("FLOUR") && Peso >= 50)
                        {
                            Peso = Peso - 50;
                            KiloOfFlour = KiloOfFlour + 12.5;
                            Console.WriteLine("Flour Fillment Sucessful!");
                        }
                        else if (WhatWantToBuy.Contains("MILK") && Peso >= 45)
                        {
                            Peso = Peso - 45;
                            MilkLitter = MilkLitter + 5;
                            Console.WriteLine("Milk Fillment Sucessful!");
                        }
                        else if (WhatWantToBuy.Contains("EGG") && Peso >= 25)
                        {
                            Peso = Peso - 25;
                            Eggs = Eggs + 5;
                            Console.WriteLine("Egg Fillment Sucessful!");
                        }
                        else if (WhatWantToBuy.Contains("MONAY") && Peso >= 65 && DoesOwnMonayRecipe == false)
                        {
                            Peso = Peso - 65;
                            DoesOwnMonayRecipe = true;
                            Console.WriteLine("Monay Recipe Purchased! Use recipe and stuff to make it");
                        }
                        else if (WhatWantToBuy.Contains("PUTO") && Peso >= 35 && DoesOwnRiceCakeRecipe == false)
                        {
                            Peso = Peso - 35;
                            DoesOwnRiceCakeRecipe = true;
                            Console.WriteLine("Puto Recipe Purchased! Use recipe and stuff to make it");
                        }
                        else if (WhatWantToBuy.Contains("PAN DE COCO") && Peso >= 55 && DoesOwnPanDeCocoRecipe == false)
                        {
                            Peso = Peso - 55;
                            DoesOwnPanDeCocoRecipe = true;
                            Console.WriteLine("Pan De Coco Purchased! Use Recipe and stuff to make it");
                        }
                        else if (WhatWantToBuy.Contains("CALCULATOR") && Peso >= 5 && DoesHaveCalculator == false)
                        {
                            Peso = Peso - 5;
                            DoesHaveCalculator = true;
                            Console.WriteLine("Purchasement Sucessful!");
                        }
                        else
                        {
                            Console.WriteLine("You've Already own the stuff, Does not have sufficient funds. or didn't type validately");
                        }
                    }
                    else if (Choice.Contains("OVERVIEW") || Choice.Contains("2"))
                    {
                        Console.WriteLine($"Flour Supply : {KiloOfFlour} Kilos");
                        Console.WriteLine($"Milk Supply : {MilkLitter} Litters");
                        Console.WriteLine($"Egg Supply : {Eggs} Eggs");
                        Console.WriteLine($"Peso Balance : {Peso}P");
                        Console.WriteLine($"Supplies Left : {HowMuchPastriesUHave}");
                    }
                    else if (Choice.Contains("MAKE") || Choice.Contains("3"))
                    {
                        string[] NameOfPastry = {"Monay(U need to buy the recipe)",
                                "Pan De Coco (You need to buy recipe)", "Puto rice cake(You need to buy recipe)"};
                        string[] FirstOfPastry = { "2 Flour", "1.5 Flour", "2 Milk" };
                        string[] SecondOfPastry = { "2 Eggs", "1 Milk", "Nothing At all"};

                        Console.WriteLine("Welcome, Please pick Recipes and type exactly");
                        for(int w = 0; w < 3; w++)
                        {
                            Console.WriteLine("-------------------");
                            Console.WriteLine(NameOfPastry[w]);
                            Console.WriteLine(FirstOfPastry[w]);
                            Console.WriteLine(SecondOfPastry[w]);
                            Console.WriteLine("-------------------");

                        }
                    }
                    else if (Choice.Contains("SAVE"))
                    {
                        Console.WriteLine("oui oui oui, what slot to occupy?");
                        string WhatSlotToOccupy = Console.ReadLine()!;
                        if (WhatSlotToOccupy.ToLower().Contains("slot") && WhatSlotToOccupy.Contains('1'))
                        {
                            File.WriteAllText(FilePath + @"slot1.txt", $"Already Made Monay\n{AlreadyMadeMonay}\nAlready Made Pan De Coco\n{AlreadyMadePanDeCoco}\n" +
                                $"Already Made Puto\n{AlreadyMadePuto}\nKilo Of Flour\n{KiloOfFlour}\nPeso\n{Peso}\nMilk\n{MilkLitter}\nPastry Supply\n{HowMuchPastriesUHave}\n"
                                + $"Eggs\n{Eggs}\nMeralco Game Over\n{MeralcoGameOver}\nWater Game Over\n{WaterGameOver}\nShop Upkeep\n{ShopUpkeepOver}\n"
                                + $"Does Own Rice Cake Recipe\n{DoesOwnRiceCakeRecipe}\nDoes Own Monay Recipe\n{DoesOwnMonayRecipe}\nDoes Own Pan De Coco\n{DoesOwnPanDeCocoRecipe}\n"
                                + $"Does Own A Calculator\n{DoesHaveCalculator}\nZ\n{z}\nO\n{o}");
                        }
                        else if (WhatSlotToOccupy.ToLower().Contains("slot") && WhatSlotToOccupy.Contains('2'))
                        {
                            File.WriteAllText(FilePath + @"slot2.txt", $"Already Made Monay\n{AlreadyMadeMonay}\nAlready Made Pan De Coco\n{AlreadyMadePanDeCoco}\n" +
    $"Already Made Puto\n{AlreadyMadePuto}\nKilo Of Flour\n{KiloOfFlour}\nPeso\n{Peso}\nMilk\n{MilkLitter}\nPastry Supply\n{HowMuchPastriesUHave}\n"
    + $"Eggs\n{Eggs}\nMeralco Game Over\n{MeralcoGameOver}\nWater Game Over\n{WaterGameOver}\nShop Upkeep\n{ShopUpkeepOver}\n"
    + $"Does Own Rice Cake Recipe\n{DoesOwnRiceCakeRecipe}\nDoes Own Monay Recipe\n{DoesOwnMonayRecipe}\nDoes Own Pan De Coco\n{DoesOwnPanDeCocoRecipe}\n"
    + $"Does Own A Calculator\n{DoesHaveCalculator}\nI\n{z}\nO\n{o}");
                        }
                        else if (WhatSlotToOccupy.ToLower().Contains("slot") && WhatSlotToOccupy.Contains('3'))
                        {
                            File.WriteAllText(FilePath + @"slot3.txt", $"Already Made Monay\n{AlreadyMadeMonay}\nAlready Made Pan De Coco\n{AlreadyMadePanDeCoco}\n" +
    $"Already Made Puto\n{AlreadyMadePuto}\nKilo Of Flour\n{KiloOfFlour}\nPeso\n{Peso}\nMilk\n{MilkLitter}\nPastry Supply\n{HowMuchPastriesUHave}\n"
    + $"Eggs\n{Eggs}\nMeralco Game Over\n{MeralcoGameOver}\nWater Game Over\n{WaterGameOver}\nShop Upkeep\n{ShopUpkeepOver}\n"
    + $"Does Own Rice Cake Recipe\n{DoesOwnRiceCakeRecipe}\nDoes Own Monay Recipe\n{DoesOwnMonayRecipe}\nDoes Own Pan De Coco\n{DoesOwnPanDeCocoRecipe}\n"
    + $"Does Own A Calculator\n{DoesHaveCalculator}\nI\n{z}\nO\n{o}");
                        }
                        else
                        {
                            Console.WriteLine("Slot does not exist or it's invalid");
                        }
                    }
                    string RecipeInput = Console.ReadLine()!; RecipeInput = RecipeInput.ToUpper();

                    switch (RecipeInput)
                    {
                        case "MONAY":
                            if (KiloOfFlour >= 2 && Eggs >= 2 && DoesOwnMonayRecipe == true && AlreadyMadeMonay == false)
                            {
                                Console.WriteLine("Making Recipe, Please wait!");
                                Thread.Sleep(5000);
                                KiloOfFlour -= 2;
                                Eggs -= 2;
                                AlreadyMadeMonay = true;
                                Pastries.Add("Monay");
                                PastriesPrice.Add(45);
                                Pastries.Add("Choocolate Monay");
                                PastriesPrice.Add(46);
                                Console.WriteLine("New Item : Monay");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Supplies : needs 2 kilos of flour and 2 eggs or you already made it");
                            }
                            break;
                        case "PAN DE COCO":
                            if (KiloOfFlour >= 1.5 && MilkLitter >= 1 && DoesOwnPanDeCocoRecipe == true && AlreadyMadePanDeCoco == false)
                            {
                                Console.WriteLine("Making Recipe, Please Wait!");
                                Thread.Sleep(3500);
                                MilkLitter -= 1;
                                KiloOfFlour -= 1.5;
                                DoesOwnPanDeCocoRecipe = true;
                                Pastries.Add("Pan De Coco");
                                PastriesPrice.Add(35);
                                Pastries.Add("Poked Pan De Coco");
                                PastriesPrice.Add(34);
                                Console.WriteLine("Recipe Sucessful!");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Supplies or you already made the recipe");
                            }
                            break;
                        default:
                            if (RecipeInput.Contains("PUTO") && MilkLitter >= 2 && DoesOwnRiceCakeRecipe == true && AlreadyMadePuto == false)
                            {
                                Console.WriteLine("Making Recipe, Please wait");
                                Thread.Sleep(4000);
                                MilkLitter -= 2;
                                AlreadyMadePuto = true;
                                Pastries.Add("Puto");
                                PastriesPrice.Add(25);
                                Pastries.Add("Chesse Puto");
                                PastriesPrice.Add(24);
                                Console.WriteLine("Recipe Sucessful!");
                            }
                            else
                            {
                                Console.WriteLine("Invali");
                            }
                            break;
                    }
                }
                double MeralDouble = Convert.ToDouble(MeralInt);
                double WaterDouble = Convert.ToDouble(WaterInt);
                double BakeDouble = Convert.ToDouble(BakeInt);
                Console.WriteLine("It's the bill time, please consider paying for your uitlity");
                Console.WriteLine($"Meralco Bill : {MeralDouble} Peso");
                Console.WriteLine($"Water Bill : {WaterDouble} Peso");
                Console.WriteLine($"Bakery Upkeep : {BakeDouble} Peso");

                if (Peso >= MeralDouble)
                {
                    Peso = Peso - MeralDouble;
                    MeralcoGameOver = 0;
                    Console.WriteLine($"Meralco Has taken {MeralDouble} As a payment to your electric bill");
                }
                else
                {
                    MeralcoGameOver++;
                    Console.WriteLine("You Do Not Have Enough Peso To Cover You Meralco Bill, Failure To Pay 3 times and game over");
                }
                Thread.Sleep(750);
                if (Peso >= WaterDouble)
                {
                    Peso = Peso - WaterDouble;
                    WaterGameOver = 0;
                    Console.WriteLine($"Your Local Water Station Taken {WaterDouble} As A Payment To Your Water Bill");
                }
                else
                {
                    WaterGameOver++;
                    Console.WriteLine("Insufficient Funds to cover water bill");
                }
                Thread.Sleep(750);
                if (Peso >= BakeDouble)
                {
                    Peso = Peso - BakeDouble;
                    ShopUpkeepOver = 0;
                    Console.WriteLine($"The Upkeep of your bakery has taken {BakeDouble} From Your Balance");
                }
                else
                {
                    ShopUpkeepOver++;
                    Console.WriteLine("Insufficient Funds to Cover Shop Upkeep");
                }
            }
        }
    }
}
// HOW TO PLAY
// for each 15 customers u process, u get  a bill
// u  can buy new recipes from the shop
// this tutorial suggest that you mind your own wallet because there's bills
// each time you run out of pastries, u have to refill which cost valuable rescoures
// To buy an item, u must get 5 customers and the game will show what u wanna do, type Buy or 1 to buy something
// u must buy an item by its name, not number index. Rememeber this please!
