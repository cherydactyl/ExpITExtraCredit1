using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class ToDo
    {
        //define the list of states
        static Dictionary<int,string> states = new Dictionary <int,string> {{0, "To-Do"}, {1, "In Progress"}, {2,"Done"}};

        string tag { get; set; }            //a short/keyword description
        string description { get; set; }    //longer description
        DateTime dueDate { get; set; }      //when the item is due to be completed by
        DateTime creationDate;              //the automatically generated creation date of the item
        int state { get; set; }             //stores the state key, as per the dictionary above

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
            this.creationDate = DateTime.Now;
            this.tag = t;
            this.description = d;
            //Set the default to 1 day from Now, since it is not specified
            this.dueDate = DateTime.Now.AddDays(1);
            this.state = 0;     //set item as "To-Do"
        }

        //looks up and returns the status as a string
        public string getState()
        {
            return states[this.state];      //returns the state by its name (string)
        }

        //returns true if the status is To-Do, otherwise false
        public bool isToDo()
        {
            return this.getState() == "To-Do";
        }

        //returns true if the status is InProgress, otherwise false
        public bool isInProgress()
        {
            return this.getState() == "In Progress";
        }

        //returns true if the status is Done,. otherwise false
        public bool isDone()
        {
            return this.getState() == "Done";
        }

        //returns the description
        public string getDescription()
        {
            return this.description;
        }

        //returns the tag
        public string getTag()
        {
            return this.tag;
        }

        //returns a DateTime object of the due date
        public DateTime getDueDate()
        {
            return this.dueDate;
        }

        //returns a DateTime object of when the item was created
        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        //
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
