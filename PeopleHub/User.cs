using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PeopleHub
{
    //creating ABSTRACT Class will keep students from being created without a user
    //you can stop people from instantiating a class by including this keyword
    //if I left abstract in, an error would occur in the Program class if I tried to access 'User'

    //public abstract class User

    //THIS IS MY BASE CLASS
    public class User
    {
        //this is the default constructor with some text for this class
        public User()
        {
            Console.WriteLine("user being created");
        }


        //every USER we have will have these properties:

        public bool Verified { get; set; } = false;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FoodPref { get; set; }

        public string FullName 
        { 
            get
            {
                return FirstName + " " + LastName;
            }
        }

        //once you have the properties created, go back to Main to create the objects





        //METHODS ARE BELOW

        public string GetUserFullName() //does this even work?
        {
            return FirstName + " " + LastName;
        }


        //I'm adding VIRTUAL as a result because I want to override from Student.cs 
        //I could add abstract if I kept abstract keyword in the user class name definition
        //public abstract void HelloToConsole(); -- and would have to remove the parameters; this forces something
        public virtual void HelloToConsole()
        {
            Console.Write("what do you want? " + FullName);
        }


        //this is whatever, experimenting
        public static string GetFoodPref(string pref)
        {
            return pref;
        }


        //new method to find a user/index in a list of users
        public static int Find(List<User> users, User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(user)) 
                {
                    return i;
                    //returning an index
                }
            }
            return -1;
        }


        //this is problematic

        //public static string GetUserFromList (List<User> users, User user)
        //{
        //    foreach (User ugg in users)
        //    {
        //        if(ugg.Equals(user))
        //        {
        //            return ugg;
        //        }
        //  }
        //    return null;
        //}
        

    }

}
