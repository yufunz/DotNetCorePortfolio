using System.ComponentModel.DataAnnotations;

namespace DotNetCorePortfolio.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [Required]
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
