using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATCLab1.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Minimum 3, Maximum 25 Characters.")]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Minimum 3, Maximum 25 Characters.")]
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        [InverseProperty("CurrentClient")]
        public Room? CurrentRoom { get; set; } = null;
        [InverseProperty("PreviousClient")]
        public Room? PreviousRoom { get; set; } = null;
    }
}
