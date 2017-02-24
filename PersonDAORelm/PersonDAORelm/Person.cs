using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDAORelm
{
    public class Person : RealmObject
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string id { get; set; }
        public string age { get; set; }

        public Person(string fname, string lname, string id, string age)
            
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.age = age;
        }

        public Person()
        {

        }
    }
}
