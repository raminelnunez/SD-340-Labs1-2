using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATCLab1.Models
{
    public class Credit
    {
        public int Id { get; set; }
        public bool IsValid { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20, ErrorMessage = "Maximum 20 Characters.")]
        public string HolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Client Client { get; set; }
    }
}
