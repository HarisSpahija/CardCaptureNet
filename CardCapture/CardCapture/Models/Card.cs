using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardCapture.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Card_Type { get; set; }
        public string Type { get; set; }
        public string Family { get; set; }
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Level { get; set; }
        public string Property { get; set; }
    }
}
