using System.ComponentModel.DataAnnotations;
using Telerik.Blazor.Components.Editor;

namespace CricketManager.Models
{
    public class CricketTeam
    {
        public InsertImage Logo { get; set; }

        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public string NumberofPlayers { get; set; }
    }
}
