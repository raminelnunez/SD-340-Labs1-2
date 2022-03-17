using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATCLab1.Models
{
    public enum Section { First, Second, Third };
    public class Room
    {
        [Key]
        [Display(Name = "Room Number")]
        public int RoomNumer { get; set; }
        public int Capacity { get; set; }
        public Section Section { get; set; }
        [ForeignKey("Client")]
        public Client? CurrentClient { get; set; } = null;
        [ForeignKey("Client")]
        public Client? PreviousClient { get; set; } = null;
    }
}
