using System;

namespace Lab_2_final.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string PathToPhoto { get; set; }

        public string Specialty { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public double AverageScore { get; set; }

        public bool IsMathPassed { get; set; }
        public bool IsRussianPassed { get; set; }
        public bool IsHistoryPassed { get; set; }

        public string Menu { get; set; }

        public Address Address { get; set; }

        public Job Job { get; set; }
    }
}
