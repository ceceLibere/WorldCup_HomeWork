using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WorldCupRussia.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }

        [NotMapped]
        public int FirstTeamId { get; set; }
        public Team FirstTeam { get; set; }

        [NotMapped]
        public int SecondTeamId { get; set; }
        public Team SecondTeam { get; set; }

        [Required]
        [DisplayName("Match Date")]
        [DataType(DataType.Date)]
        public DateTime MatchDateTime { get; set; }

        [StringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string MatchInfo { get; set; }
    }
}