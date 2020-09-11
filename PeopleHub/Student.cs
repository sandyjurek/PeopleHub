using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleHub
{
    class Student : User
    {
        //this calls its base class USER for method
        //THIS IS A DERIVED CLASS
        
        //this is the default constructor - it is assumed to be here even if it's not
        public Student()
        {
            Console.WriteLine("creating student");
        }

        // method HelloToConsole has to have 'virtual' after public
        public override void HelloToConsole()
        {
            //this is to just call what's in the base
            base.HelloToConsole();
            Console.WriteLine("&&&&&&&&&&&&&&&&&");

            //this is to write something
            Console.WriteLine("Hi, I'm a student, my name is " + FullName.ToUpper());


        }
    }
}
