using System;

namespace СurrencyСonverter
{
    class Program
    {

        static void Main(string[] args)
        {
            int rubToUsd = 70;
            float rub;
            float usd;
            string userInput;
            string exitLoop = "exit";
            float currencyCount;
            Console.WriteLine("Обменник валют");
            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс доларов: ");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.WriteLine($"Для выхода из программы введите  {exitLoop}");

            userInput = Console.ReadLine();

            while (userInput != exitLoop)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары ");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                }

                Console.WriteLine($"Ваш баланс {rub} рублей и {usd} долларов");
                Console.WriteLine("1 - обменять рубли на доллары");
                Console.WriteLine("2 - обменять доллары на рубли");
                Console.WriteLine($"Для выхода из программы введите  {exitLoop}");

                userInput = Console.ReadLine();
            }  
        }
    }
}
