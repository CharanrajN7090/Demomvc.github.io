using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class EmailObject
    {
        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
    }
}
