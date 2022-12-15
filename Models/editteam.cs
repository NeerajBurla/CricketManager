using System.ComponentModel.DataAnnotations;

namespace CricketManager.Models
{
    public class EditTeam
    {

        [Required(ErrorMessage = "Name is mandatory and can be 30 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manager is mandatory and can be 50 chars")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "Contact Number only allows numbers")]
        public int Contact { get; set; }
        [Required(ErrorMessage = "Contact Number only allows numbers")]
        public string TeamName { get; set; }


    }
}
