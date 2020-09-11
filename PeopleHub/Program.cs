using System;
using System.Collections.Generic;

namespace PeopleHub
{
    //namespace -> classes -> members -> methods -> statements (order of operations)

    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FirstName = "Sandy";
            user.LastName = "Jurek";
            //here we create an Object (or a 'user') -- and the 2 properties I'm required to have from User class

            //Here I'm calling my 'Print' method I have below - this is the first thing that prints to console (hell @
            Program myNewMethod = new Program();
            myNewMethod.Print();

            Console.WriteLine("------------------");

            //these next 2 lines do the exact same thing:
            Console.WriteLine($"Hello new object: " + user.FirstName + " " + user.LastName);
            Console.WriteLine(user.GetUserFullName());

            //below is turning chars of a string into a single word 'hello' and concatenating a sentence
            string brokenName = "Max";
            char[] characters = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(characters);
            string message = $"Hello my name is {brokenName} and I like to say {greeting}";
            Console.WriteLine(message);

            //below is a string that will find the word in the index of [1] and display it; the ' ' space is the delimiter in this case
            string combinedWords = "Hi there my name is Thom";
            string[] separateWords = combinedWords.Split(' ');
            Console.WriteLine(separateWords[5]);

            //below gets the number of characters
            string numberOfChars = "Sparky";
            Console.WriteLine(numberOfChars.Length);

            // OR this compares a string to give a negative or positive (0)
            Console.WriteLine(numberOfChars.CompareTo("Spanky"));

            // AND
            int position = numberOfChars.IndexOf("ky", 2);
            Console.WriteLine(position);

            //getting user input and printing it back out:
            Console.WriteLine("___________________");
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine($"You like to eat {food} {numberOfChars}!");


            //getting user food preference from method in User class?



            //setting this up to use Student class below
            Program myProgram = new Program();
            myProgram.DoSomething();
        }


        //here is a new method; call it from above
        void Print()
        {
            Console.WriteLine("hell");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@");
        }


        //new Student class and new Teacher class
        public void DoSomething()
        {
            Student me = new Student();
            me.FirstName = "Jingle";
            me.LastName = "Bells";
            me.Verified = true;
            Console.WriteLine(me.FullName);
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%");

            Teacher you = new Teacher();
            you.FirstName = "Stanley";
            you.LastName = "Tools";
            you.Verified = true;
            Console.WriteLine(you.FullName);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");

            //both Student and Teacher are USERS so we can just pull a list of USERS below:
            List<User> users = new List<User>() { me, you };

            foreach (User u in users)
            {
                u.HelloToConsole();
            }

            // I COMMENT OUT BELOW IN ORDER TO EVOKE THE LIST AND FOREACH ABOVE - BOTH CANNOT CO-EXIST
            //me.HelloToConsole();
        }

    }
}
