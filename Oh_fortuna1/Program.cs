using System;

namespace Oh_fortuna1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice1 = 0;
            int dice2 = 0;
            int dice3 = 0;
            int pix = 500;
            int luckyNum = 0;
            int bet = 0;

            string result;


            Console.WriteLine("Du har " + pix + " pix att betta med. Skriv in hur många pix du vill betta: ");

            string betStr = Console.ReadLine();
            int.TryParse(betStr, out bet);

            pix -= bet;

            Console.WriteLine("Skriv in ett lyckonummer: ");

            string luckyStr = Console.ReadLine();
            int.TryParse(luckyStr, out luckyNum);

            dice1 = RandomMethod();

            dice2 = RandomMethod();

            dice3 = RandomMethod();

            Console.WriteLine("Dina tal är: " + dice1 + " " + dice2 + " " + dice3);

            int winMult = 1;
            if(dice1 == luckyNum)
            {
                winMult += 1;
            }
            if (dice2 == luckyNum)
            {
                winMult += 1;
            }
            if (dice3 == luckyNum)
            {
                winMult += 1;
            }
            else if(winMult<2)
            {
                winMult = 0;
            }


            pix += (bet * winMult);

            Console.WriteLine(pix);



        }

        

        private static int RandomMethod()
        {
            
            int ran;
            Random rand = new Random();
            ran = rand.Next(1, 7);
            return ran;
        }
    }

}   
