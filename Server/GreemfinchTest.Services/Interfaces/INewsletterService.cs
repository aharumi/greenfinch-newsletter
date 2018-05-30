using GreenfinchTest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreemfinchTest.Services.Interfaces
{
    public interface INewsletterService
    {
        Newsletter RegisterNewsletter(Newsletter newsletter);
    }
}
