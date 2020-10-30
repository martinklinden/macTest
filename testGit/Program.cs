using System;

namespace testGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string personNummer = "1612122242";
            int collectNumbers = 0;
            Console.WriteLine(personNummer);
            //convert last number to int
            string lastNumberString = personNummer.Substring(9, 1);
            int lastNumber = int.Parse(lastNumberString);
            Console.WriteLine("Sista numret är {0}", lastNumber);
            //for loop
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine(personNummer[i]);
                //convert current number to int
                string numberString = personNummer.Substring(i, 1);
                int number = int.Parse(numberString);
                //if place in array (i) is dividable with 2
                if (i % 2 == 0)
                {
                    int number2 = number * 2;
                    if (number2 >= 10)
                    {
                        string string2 = number2.ToString();
                        string string3 = string2.Substring(0, 1);
                        int number3 = int.Parse(string3);
                        collectNumbers = collectNumbers + number3;
                        string string4 = string2.Substring(1, 1);
                        int number4 = int.Parse(string4);
                        collectNumbers = collectNumbers + number4;

                    }
                    else
                    {
                        collectNumbers = collectNumbers + number2;
                    }
                }
                else
                {
                    collectNumbers = collectNumbers + number;
                }
            }
            int seeIfCorrect = collectNumbers + lastNumber;
            if (seeIfCorrect % 10 == 0)
            {
                Console.WriteLine("Summan är {0} och det är korrekt!", seeIfCorrect);
            }
            else
            {
                Console.WriteLine("Summan är {0} och det är fel!", seeIfCorrect);
            }
            Console.ReadKey();
        }
    }
}
