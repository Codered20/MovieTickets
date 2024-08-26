using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int ID {  get; set; }
        public string ProfilePicURL { get; set; }

        public string FullName {  get; set; }

        public string Bio {  get; set; }

        public List<Actor_Movie> Actor_Movie { get; set; }



    }
}
