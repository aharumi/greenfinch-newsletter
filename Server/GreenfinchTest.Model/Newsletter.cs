using System;
using System.ComponentModel.DataAnnotations;

namespace GreenfinchTest.Model
{
    public class Newsletter
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Heard { get; set; }
        public string Reason { get; set; }
    }
}
