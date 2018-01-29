using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {





        public static void List()
        {

            bool moveOn = true, program = true;

            while (program == true)
            {



                moveOn = true;
                while (moveOn == true)
                {
                Console.WriteLine("Welcome to your C# class.  Which student would you like to learn about? (Enter a number between 1 and 12");
                    Hashtable Users = new Hashtable();
                    Users.Add("1", "Andrew");
                    Users.Add("2", "Chamus");
                    Users.Add("3", "David");
                    Users.Add("4", "Aaron");
                    Users.Add("5", "Marshal");
                    Users.Add("6", "Jonathan");
                    Users.Add("7", "Albert");
                    Users.Add("8", "Adam");
                    Users.Add("9", "Tommy");
                    Users.Add("10", "Ian");
                    Users.Add("11", "Kevin");
                    Users.Add("12", "Kelsey");


                    String whichUser = Console.ReadLine();
                    int numberUser = Convert.ToInt16(whichUser);
                    if (numberUser < 1 || numberUser > 12)
                    {
                        Console.WriteLine("That student does not exist. Please try again");
                        moveOn = false;
                    }

                    else
                    {


                        whichUser = Convert.ToString(Users[whichUser]);
                        Console.WriteLine("Student " + numberUser + " is " + whichUser + ".  What would you like to know about " + whichUser + "enter \n \"home\" for hometown or \"food\" for their favorit food.");

                        string foodHomeTown = Console.ReadLine().ToLower();


                        if (foodHomeTown == "food")
                        {
                            FoodMethod(whichUser);
                        }
                        if (foodHomeTown == "home")
                        {
                            HomeTownMethod(whichUser);
                        }
                        else
                        {
                            
                           Console.WriteLine("I'm sorry, could you please use the words: \"food\" or \"home\"? ");
                            List();
                            
                        }

                    }
                }
            }
        }

        public static void FoodMethod(String whichUser)
        {

            Hashtable Food = new Hashtable();
            Food.Add("Andrew", "Steak");
            Food.Add("Chamus", "Sushi");
            Food.Add("David", "Lasagna");
            Food.Add("Aaron", "Ribeye");
            Food.Add("Marshal", "Burgers");
            Food.Add("Jonathan", "Stouts");
            Food.Add("Albert", "Pounded Potatoes and Beans");
            Food.Add("Adam", "Putine");
            Food.Add("Tommy", "Chicken Curry");
            Food.Add("Ian", "Alfredo");
            Food.Add("Kevin", "Oatmeal");
            Food.Add("Kelsey", "Posted a survey.");

            Console.WriteLine(whichUser);
            Console.WriteLine(whichUser + "'s favorit food is " + Food[whichUser]);
            List();


        }

        public static void HomeTownMethod(String whichUser)
        {

            Hashtable HomeTown = new Hashtable();
            HomeTown.Add("Andrew", "Fremont");
            HomeTown.Add("Chamus", "Zeeland");
            HomeTown.Add("David", "Fort Wayne");
            HomeTown.Add("Aaron", "Hart");
            HomeTown.Add("Marshal", "Holland");
            HomeTown.Add("Jonathan", "Middleville");
            HomeTown.Add("Albert", "Grand Rapids");
            HomeTown.Add("Adam", "Grand Rapids");
            HomeTown.Add("Tommy", "Raleigh");
            HomeTown.Add("Ian", "Allendale");
            HomeTown.Add("Kevin", "Chicago");
            HomeTown.Add("Kelsey", "Posted a survey.");

            Console.WriteLine(whichUser);
            Console.WriteLine(whichUser + "'s home town is " + HomeTown[whichUser]);
            List();


        }









        static void Main(string[] args)
        {


            List();
        }

    }
}
