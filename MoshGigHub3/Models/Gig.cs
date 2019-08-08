using System;
using System.ComponentModel.DataAnnotations;

namespace MoshGigHub3.Models
{
    public class Gig
    {
        public int Id { get; set; }

        // navigation property
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        // navigation property
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}