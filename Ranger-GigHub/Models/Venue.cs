using System.ComponentModel.DataAnnotations;

namespace Ranger_GigHub.Models
{
    public class Venue
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string VenueName { get; set; }
        
        [Required]
        public int VenueZipCode { get; set; }

        [StringLength(255)]
        public string VenueDescription { get; set; }

        public int Capacity { get; set; }

        public int VenueRate { get; set; }
    }
}
