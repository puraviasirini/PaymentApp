using Microsoft.EntityFrameworkCore;

namespace PaymentApp.API.Models
{
    public class PaymentDetailContext :DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
