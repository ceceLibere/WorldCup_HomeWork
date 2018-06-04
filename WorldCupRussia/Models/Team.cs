using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCupRussia.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }

        public string Continent { get; set; }

        [StringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string TeamInfo { get; set; }

        public List<Player> Players { get; set; }
    }
}