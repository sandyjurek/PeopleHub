using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleHub
{
    class Teacher : User
    {
        //this is another DERIVED CLASS same as Student.cs

        public Teacher()
        {
            Console.WriteLine("creating teacher");
        }

        public override void HelloToConsole()
        {
            Console.WriteLine("Hi, I'm a teacher, my name is " + FullName);
        }
    }
}
