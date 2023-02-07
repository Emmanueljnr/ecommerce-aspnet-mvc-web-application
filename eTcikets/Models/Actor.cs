using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile Picture")] //this is so that i dont have to repeat myself in the Views
        [Required(ErrorMessage = "Profile Picture is Required")] //if a user doesnt give these details, the model state decalread the create method within my controller, will be invalid
        public string ProfilePictureURL { get; set; }
        
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")] //just a form of validation      
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")] //just a form of validation 
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; } //Many to many Relationship
        //I HAVE JUST DEFINED THE JOINING TABLE IN THE LINE ABOVE
    }
}
