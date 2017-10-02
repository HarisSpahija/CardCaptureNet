using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CardCapture.Models;

namespace CardCapture.Models
{
    public class CardCaptureContext : DbContext
    {
        public CardCaptureContext (DbContextOptions<CardCaptureContext> options)
            : base(options)
        {
        }

        public DbSet<CardCapture.Models.Collection> Collection { get; set; }

        public DbSet<CardCapture.Models.Card> Card { get; set; }
    }
}
