using GreenfinchTest.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace GreenfinchTest.Data
{
    public class NewsletterContext : DbContext
    {
        public NewsletterContext(DbContextOptions<NewsletterContext> options)
            : base(options)
        {
        }

        public DbSet<Newsletter> Newsletters { get; set; }
    }
}
