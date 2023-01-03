using System.ComponentModel.DataAnnotations;
using Telerik.Blazor.Components.Editor;

namespace CricketManager.Models
{
    public class CricketTeam
    {
        public int Id { get; set; }
        public string Logo { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Manager is mandatory and can be 50 chars")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "Contact Number only allows numbers")]
        public string Contact { get; set; }

        [Display(Name = "Number of Players")]
        public string NumberofPlayers { get; set; }

        public List<addplayer> Players { get; set; }
    }
}
