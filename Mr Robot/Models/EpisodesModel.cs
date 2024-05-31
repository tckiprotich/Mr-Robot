using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mr_Robot.Models
{
    public class EpisodesModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OverallNumber { get; set; }
        public int SeasonNumber { get; set; }
        public string? Title { get; set; }
        public string? DirectedBy { get; set; }
        public string? WrittenBy { get; set; }
        public string? Description { get; set; }
        public DateTime OriginalAirDate { get; set; }
        public double USViewersMillions { get; set; }

        public int seasonId { get; set; }
        public SeasonModel? Season { get; set; }


    }
}