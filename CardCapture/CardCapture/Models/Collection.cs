using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardCapture.Models
{
    public class Collection
    {
        public int ID { get; set; }

        [ForeignKey("CardId")]
        public Card CardID { get; set; }
        public Card Name { get; set; }
    }
}
