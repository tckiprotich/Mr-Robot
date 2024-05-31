using System;

namespace Mr_Robot.Models
{
    public class SeasonModel
    {
        public int Id { get; set; }
        public int SeasonNumber { get; set; }
        public int NumberOfEpisodes { get; set; }
        public DateTime FirstAired { get; set; }
        public DateTime LastAired { get; set; }
    }
}