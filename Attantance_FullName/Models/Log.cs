using System;
using System.ComponentModel.DataAnnotations;

namespace Attantance_FullName.Models
{
    public class Log
    {
        public int ID { get; set; }
        [Required]
        public string AppUserName { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime LoginTime { get; set; }
    }
}