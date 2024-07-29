using System;

class Program
{
    static void Main()
    { 
        int menuChoice = 0;
       int contestantsPrevious = 0;
        int contestantsCurrent = 0;
         while(menuChoice != 2){
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************"); 
       Console.WriteLine();
        Console.WriteLine("Please Enter the following number below from the following menu:");
           Console.WriteLine(); 
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
        menuChoice = Convert.ToInt32(Console.ReadLine()); 


        if(menuChoice == 1){ 
            Console.WriteLine("Please enter the number of contestants in the previous year, between 0 and 30:");
           while(true){
              contestantsPrevious = Convert.ToInt32(Console.ReadLine());
                if((contestantsPrevious >= 0 && contestantsPrevious <= 30)){
                    break;
                    }
               else{
                   Console.WriteLine( "Invalid input. Please enter a number between 0 and 30.");
                   continue;
               }
               }
                
    
            Console.WriteLine("Please enter the number of contestants this year, between 0 and 30:");
            while(true){
                contestantsCurrent = Convert.ToInt32(Console.ReadLine());
                if((contestantsCurrent >= 0 && contestantsCurrent <= 30)){
                    break;
                }
                else{
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
                    continue;
                }
            }
        
            Console.WriteLine("Last year's competition had " + contestantsPrevious + " contestants, and this year's has " + contestantsCurrent + " contestants.");
            Console.WriteLine("Revenue expected this year is $" +(contestantsCurrent* 25));
            if(contestantsCurrent>(contestantsPrevious*2)){
                Console.WriteLine("The competition is more than twice as big this year!");
            } 
            else if((contestantsCurrent>contestantsPrevious) && (contestantsCurrent<=(contestantsPrevious*2))){
                Console.WriteLine("The competition is bigger than ever!"); 
                }
            else {
                Console.WriteLine(" A tighter race this year! Come out and cast your vote!");
            }

            }
            Console.WriteLine();
            Console.WriteLine();
            }



        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
        Console.ReadKey(); //holds the screen

            }
    }



