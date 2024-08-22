using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public string ProfilePicURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
