using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Instructing User to type a number
            Console.WriteLine("Please type a number: ");
            Console.ReadLine();


            //Declaring Variables 
            int x = 1;
            int answer;

            //Converting "int answer" to numerics
            answer = int.Parse(Console.ReadLine());
            
            //Looping 2-20
            for (int i = 1; i < 20; i++) //< not sure if 'i++' is needed...
            
            {                
                answer = x * i; //trying to give end result to 'answer'
                Console.WriteLine(answer); //tring to get it to print the 'answer' buuuut there is a "user' error
            }
            Console.ReadLine();

            
            
            
           
          
        }
    }
}
