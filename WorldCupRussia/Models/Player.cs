using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCupRussia.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string PlayerName { get; set; }

        public string PlayerPosition { get; set; }

        [StringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string PlayerInfo { get; set; }

        [NotMapped]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}