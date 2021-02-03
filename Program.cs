using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listapp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            // function to get app info
            getappinfo();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Please tell how many fruits you want in your basket?  \n");
            int input = Convert.ToInt32(Console.ReadLine());
           
            // a for taking the input string  from the user ..
            List<String> userList = new List<String>();

            // a for taking the input integer   from the user ..
            List<int> numberList = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                Console.Write(" please enter the {0} fruit in the basket:-     ", i);
                String answer = Console.ReadLine();
                userList.Add(answer);
            }



            Console.WriteLine(" please review the new list of fruits you made  :- ");
            // show up the list made by the user 
            Console.WriteLine("___________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var user in userList)
            {
                Console.WriteLine("|    " + user + "    |");
            }
            Console.ResetColor();
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();

            //label to goto
            truf:
            Console.WriteLine();
            Console.WriteLine(" Do you want to perform any change in  your choice of fruits ? press ENTER" +
                " if you want else ESCAPE to abort ");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Enter)
            {
                endloop:

                {
                    Console.WriteLine();

                    Console.WriteLine(" please tell which fruit you want to  replace ?   ");
                    string replacefruit = Console.ReadLine();
                    if (userList.Contains(replacefruit))    //important
                    { 

                       // var obj = userList.Where(x => x == replacefruit).FirstOrDefault();         // findthis  

                        // check if the replace fruit is aactually present in the list or not
                        userList.Remove(replacefruit);
                        Console.WriteLine("please mention new fruit to add in the  list ? ");  // for delete  value dlelte  
                        string newfruit = Console.ReadLine();
                         userList.Add(newfruit);
                       // obj = newfruit;
                    }
                    else
                    {
                        Console.WriteLine(" please enter a valid fruit as the fruit you entered is not present in the list. ");
                        goto endloop;
                    }

                    Console.WriteLine(" the newlist mentioned by you  is :- ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var user in userList)
                    {
                        Console.WriteLine("|    " + user + "    |");

                    }
                    Console.ResetColor();
                    

                }
                //label to goto
                cipla:
                Console.WriteLine(" Do you want any new change in your list ? , press ENTER to change or ESCAPE to abort ");
                ConsoleKeyInfo consoleK = Console.ReadKey();
                if (consoleK.Key == ConsoleKey.Enter)
                {
                    goto endloop;
                }


                else if (consoleK.Key == ConsoleKey.Escape)
                {
                    // write the code for gettingthe input values for the nuber  of fruits selected in the listby the user
                    
                    

                        foreach (var user in userList)
                        {
                            Console.Write(" please enter how many _{0}_  you need to have ", user.ToUpper());
                            int numanswer = Convert.ToInt32(Console.ReadLine());
                            numberList.Add(numanswer);
                            continue;
                        }
                    Console.WriteLine(" the entire list made by you is as follows:- ");
                    Console.WriteLine("_________________________________________________________________________________");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var user in userList)
                    {
                        Console.Write("            " + user + "            ");
                    }
                    Console.WriteLine();
                    foreach (var num in numberList)
                    {
                        Console.Write("            " + num + "            ");
                    }
                    Console.ResetColor();


                }
                else
                {

                    Console.WriteLine();
                    Console.Beep();
                    Console.WriteLine(" please enter a relevant key !!  ");
                    Console.Beep();
                    Console.ReadLine();
                    goto cipla;
                }



            }

            else if (consoleKeyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Okay !  great let's now add the quantities to the fruits selected by you !");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");                     
                               
                

                    foreach (var user in userList)
                    {
                        Console.Write(" please enter how many _{0}_  you need to have ", user.ToUpper());
                        int numanswer  = Convert.ToInt32(Console.ReadLine());
                        numberList.Add(numanswer);
                    continue; 
                    }

                Console.WriteLine(" the entire list made by you is as follows:- ");
                Console.WriteLine("_________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var user in userList)
                {
                  Console.Write("            " + user + "            ");
                }
                Console.WriteLine();
                foreach (var num in numberList)
                {
                  Console.Write("            " + num + "            ");
                }
                Console.ResetColor();




            }

            else
            {
                Console.Beep();Console.Beep();
                Console.WriteLine();
                Console.WriteLine(" please enter the relevant key ,choose from   ENTER or ESCAPE");
                goto truf;
            }






            Console.ReadLine();
                       
        }
        static void getappinfo()
        {
            string appinfo = "FRUITS LIST using LISTS ";
            string appversion = "3.0.1";
            string appauthor = "shikher raina";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("This app {0} with the version  {1} is developed by  {2} ", appinfo, appversion, appauthor);
            Console.WriteLine("________________________________________________________________________________________");
            Console.ResetColor();
        }
       
    }
}
