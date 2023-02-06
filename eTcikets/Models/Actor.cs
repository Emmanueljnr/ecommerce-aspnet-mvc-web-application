using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")] //this is so that i dont have to repeat myself in the Views
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; } //Many to many Relationship
        //I HAVE JUST DEFINED THE JOINING TABLE IN THE LINE ABOVE
    }
}
