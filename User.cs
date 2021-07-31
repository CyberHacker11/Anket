using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket
{
    class User
    {
        public static int ID { get; set; }
        public int ObjectID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{ObjectID}) {Name} {Surname}";
        }
    }
}
