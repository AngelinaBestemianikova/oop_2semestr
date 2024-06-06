using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Model
{
    public class Medcentre
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
       
        public string Category { get; set; }
        public string Department { get; set; }
        public string time { get; set; }
        public DateOnly date { get; set; } 

        public bool isFree { get; set; }

        public Medcentre(string name, string spec, string category, string department, string timr, DateOnly date, bool boo = true)
        {
            this.Name = name;
            this.Specialization = spec; 
            this.time = timr;
            this.date = date;
            this.isFree = boo;
            this.Department = department;
            this.Category = category;
        }

    }
}
