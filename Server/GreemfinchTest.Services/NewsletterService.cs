using GreemfinchTest.Services.Interfaces;
using GreenfinchTest.Data;
using GreenfinchTest.Model;
using System.Linq;

namespace GreemfinchTest.Services
{
    public class NewsletterService : INewsletterService
    {
        NewsletterContext _context;
        public NewsletterService(NewsletterContext context)
        {
            _context = context;
        }

        public Newsletter RegisterNewsletter(Newsletter newsletter)
        {
            if(CheckIfEmailExist(newsletter))
            {
                return null;
            }
            _context.Add(newsletter);
            _context.SaveChanges();
            return newsletter;
        }

        private bool CheckIfEmailExist(Newsletter newsletter)
        {
            return _context.Newsletters.Any(n => n.Email.Equals(newsletter.Email));
        }
    }
}
