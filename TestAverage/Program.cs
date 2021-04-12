using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local Variables
            double testOne;
            double testTwo;
            double testThree;
            double testFour;
            double testAverage;

            //Get user to input test scores
            Console.Write("Please enter the score for the first test:  ");
            testOne = double.Parse(Console.ReadLine());
            
            Console.Write("Please enter the score for the second test:  ");
            testTwo = double.Parse(Console.ReadLine());
            
            Console.Write("Please enter the score for the third test:  ");
            testThree = double.Parse(Console.ReadLine());
           
            Console.Write("Please enter the score for the fourth test:  ");
            testFour = double.Parse(Console.ReadLine());

            //Get Test Average
            testAverage = (testOne + testTwo + testThree + testFour) / 4;

            //Display Test Average To User
            Console.WriteLine("The average score of your four tests combined is {0:f2}", testAverage);

            
            
            //Display If/Else Statement
            if (testAverage >= 95)
            {
                Console.WriteLine("Congratulations, you're an all star!");
            }
            else
            {
                Console.WriteLine("Keep your head up and stick with it!");
            }//End If/Else Statement
          

            //Hold Window Open
            Console.ReadKey();




        }//End Main

    }//End Class

}//End Namespace
       
