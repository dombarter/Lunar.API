using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lunar.Models
{
    public class Moon
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Radius { get; set; }
        [Required]
        public DateTime DiscoveredDate { get; set; }
    }
}