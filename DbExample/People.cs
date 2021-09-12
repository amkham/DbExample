using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample
{
    class People
    {

        private int id;
        private string name, age, data;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Data { get => data; set => data = value; }


        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + Data;
        }

        public string[] toArray()
        {

            string[] result = new string[4];

            result[0] = Id.ToString();
            result[1] = Name;
            result[2] = Age;
            result[3] = Data;

            return result;
        }
    }
}
