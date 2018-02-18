using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attantance_FullName.Models
{
    public class Blog
    {
        public int ID { get; set; }
        [Required]
        public string Heading { get; set; }
        public string Content { get; set; }
        [Required, ForeignKey("AppUser")]
        public string AppUserID { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}