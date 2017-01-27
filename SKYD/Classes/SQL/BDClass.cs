using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYD.Classes.SQL
{
    class BdClass
    {
        public class Unit
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Dorm
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Faculties
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Courses
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Fpps
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class turnstiles
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Ip_adress { get; set; }
            public int statys { get; set; }
        }
    }
}
