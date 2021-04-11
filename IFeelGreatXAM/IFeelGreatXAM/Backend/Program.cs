using System;

namespace IFeelGreat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //65 male 65 no / 0 yes
            //35 female 17.5 no / 17.5 yes
            Console.WriteLine("Welcome, Please Enter Company Name");
            string companyname = Console.ReadLine();
            



            Console.Write("Please Enter Male Ratio(Syntax 0,xx): ");
            double maleRatio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Male 'YES' Response Ratio(Syntax 0,xx): ");
            double maleYes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Female 'YES' Response Ratio(Syntax 0,xx): ");
            double femaleYes = Convert.ToDouble(Console.ReadLine());

            
            Solution solution = new Solution(maleRatio,maleYes,femaleYes);
            
            while (true)
            {
                Console.Write("Do You Feel Great?(Yes/No)");
                String answer = Console.ReadLine().Trim().ToLowerInvariant();
                switch (answer)
                {
                        case "yes":
                        Console.WriteLine(companyname + " Company 'I Feel Great' Survey Result");
                        solution.probabilityYes();
                        Console.WriteLine("Have a Good Day " + companyname + " :)");

                        break;
                        case "no":
                        Console.WriteLine(companyname + " Company 'I Feel Great' Survey Result");
                        solution.probabilityNo();
                        Console.WriteLine("Have a Good Day "+companyname+" :)");
                        break;
                    default:
                        Console.WriteLine("Please Rrovide A Valid Answer(Yes/No)");
                        break;



                }


            }





            


        }
    }
}