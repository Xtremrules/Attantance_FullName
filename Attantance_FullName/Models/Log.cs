using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attantance_FullName.Models
{
    public class Log
    {
        public int ID { get; set; }
        [ForeignKey("AppUser"), Required]
        public string AppUserID { get; set; }
        public ApplicationUser AppUser { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime LoginTime { get; set; }
    }
}