using System.ComponentModel.DataAnnotations;

namespace CricketManager.Models
{
    public class CricketTeam
    {
        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public string NumberofPlayers { get; set; }
    }
}
