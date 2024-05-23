using System;
class   Alloria_Coffee   
{
    static void Main()
    {
        string Predikat, confirm;
        do
        {

            Console.WriteLine("Alloria Coffe");
            Console.WriteLine();
            int pilih;
            string masuk;
            Console.WriteLine("New Variant 'Strawnilla Coffee'.");
            Console.WriteLine("Get Alloria's coffee with special strawberry and vanilla milk, now!");
            Console.WriteLine();
            Console.WriteLine("Special price by 'Strawnilla Package':");
            Console.WriteLine("1) Special Package");
            Console.WriteLine("2) Package A");
            Console.WriteLine("3) Package B");
            Console.WriteLine("4) Package C");
            Console.WriteLine();
            Console.WriteLine("Input Package Number ");
            Console.WriteLine("Input :");
            masuk = Console.ReadLine();
            pilih = Convert.ToInt32(masuk);
            if (pilih == 1)
            {
                Console.WriteLine("#50.000 = Strawnilla Coffee + Special Strawberry Pocket");
            }
            else if (pilih == 2)
            {
                Console.WriteLine("#64.999 = Strawnilla Coffee + Waffle");
            }
            else if (pilih == 3)
            {
                Console.WriteLine("#59.999 = Strawnilla Coffee + Chips");
            }
            else if (pilih == 4)
            {
                Console.WriteLine("#89.999 = Strawnilla Coffee + Waffle + Chips");
            }
            else
            {
                Console.WriteLine("Error, wrong code.");

                masuk = Console.ReadLine();
                pilih = Convert.ToInt32(masuk);
            }
            for (int i = 1; i > 0; i--) ;
            {
                for (int j = 1; j > 0; j++) ;
                {
                    Console.WriteLine();
                    Console.WriteLine("Are you sure?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("Input :");
                    masuk = Console.ReadLine();
                    pilih = Convert.ToInt32(masuk);
                    if (pilih == 1)
                    {

                        Console.WriteLine("Thank You for your order! Please wait.");
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please input your correct order number!");
                        Console.WriteLine("Input :");
                    }
                    masuk = Console.ReadLine();
                    pilih = Convert.ToInt32(masuk);
                    if (pilih == 1)
                    {
                        Console.WriteLine("#50.000 = Strawnilla Coffee + Special Strawberry Pocket");
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("#64.999 = Strawnilla Coffee + Waffle");
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("#59.999 = Strawnilla Coffee + Chips");
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("#89.999 = Strawnilla Coffee + Waffle + Chips");
                    }
                    else
                    {
                        Console.WriteLine("Error, wrong code.");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Order again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine("Input :");
            confirm = Console.ReadLine();
            pilih = Convert.ToInt32(masuk);
            if (pilih == 2)
            {

                Console.WriteLine("Thank You for your order! Please wait.");
            }                                           

            Console.Clear();

        } while (confirm == "1");

    }
}