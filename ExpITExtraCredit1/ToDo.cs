using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class ToDo
    {
        static Dictionary<int,string> states = new Dictionary <int,string> {{0, "To-Do"}, {1, "In Progress"}, {2,"Done"}};
        string tag { get; set; }            //a short/keyword description
        string description { get; set; }    //longer description
        DateTime dueDate { get; set; }
        DateTime creationDate;
        int state { get; set; }

        ToDo()
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "cleanup";
            this.description = "maintenance and cleanup on to do items";
            //Set the default to 1 day from Now
            this.dueDate = DateTime.Now.AddYears(1);
            this.state = 0;     //set item as "To-Do"
        }
        //contstructor takes one string (description) and one DateTime deadline parameter
        ToDo(string d, DateTime due)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "";
            this.description = d;
            this.dueDate = due;
            this.state = 0;     //set item as "To-Do"
        }
        //contstructor takes two strings (tag and description) and one DateTime deadline parameter
        ToDo(string t, string d, DateTime due)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = t;
            this.description = d;
            this.dueDate = due;
            this.state = 0;     //set item as "To-Do"
        }
        //contstructor takes one string (description) and sets due date to 1 day after creation
        ToDo(string d)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "";
            this.description = d;
            //Set the default to 1 day from Now
            this.dueDate = DateTime.Now.AddDays(1);
            this.state = 0;     //set item as "To-Do"
        }

        ToDo(string t, string d)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = t;
            this.description = d;
            //Set the default to 1 day from Now
            this.dueDate = DateTime.Now.AddDays(1);
            this.state = 0;     //set item as "To-Do"
        }
        public string getState()
        {
            return states[this.state];      //returns the state by its name (string)
        }
        public string getDescription()
        {
            return this.description;
        }
        public string getTag()
        {
            return this.tag;
        }
        public DateTime getDueDate()
        {
            return this.dueDate;
        }
        public DateTime getCreationDate()
        {
            return this.creationDate;
        }
        public void print()
        {
            if (this.tag != "")
            {
                Console.WriteLine(this.tag);
            }
            Console.Write(description);
            Console.WriteLine("Created on " + creationDate.ToString());
            Console.WriteLine("Due on " + dueDate.ToString());
            Console.Write("Status" + this.getState());
        }

    }
}
