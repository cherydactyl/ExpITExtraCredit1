using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class ToDo
    {
        string tag;         //a short/keyword description
        string description; //longer description
        DateTime dueDate;
        DateTime creationDate;

        ToDo()
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "cleanup";
            this.description = "maintenance and cleanup on to do items/list";
            //Set the default to 1 day from Now
            this.dueDate = DateTime.Now.AddYears(1);
        }
        ToDo(string d, DateTime due)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "";
            this.description = d;
            this.dueDate = due;
        }
        ToDo(string t, string d, DateTime due)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = t;
            this.description = d;
            this.dueDate = due;
        }
        ToDo(string d)
        {
            //default ToDo item is by a reminder to maintain ToDo items/list
            this.creationDate = DateTime.Now;
            this.tag = "";
            this.description = d;
            //Set the default to 1 day from Now
            this.dueDate = DateTime.Now.AddDays(1);
        }

    }
}
