namespace CricketManager.Models
{
    public class PlayerRecords
    {
        public string Name { get; set; }
        public string TeamName { get; set; }    
        public int NumberofMatchesPlayed { get; set; }
        public int HighestScore { get; set; }
        public int NumberofWickets { get; }
        public int NumberofHundreds { get; set; }
        public int NumberofFifties { get; set; }
        public int NumberofSixes { get; set; }
        public int NumberofFours { get; set; }
        public int NumberofNineties { get; set; }
        
    }
}
