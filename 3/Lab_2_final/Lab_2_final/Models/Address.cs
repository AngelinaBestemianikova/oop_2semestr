using Lab_2_final.Attributes;

namespace Lab_2_final.Models
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int? FlatNumber { get; set; }

        [Index]
        public int Index { get; set; }
    }
}
