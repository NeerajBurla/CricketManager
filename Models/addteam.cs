using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CricketManager.Models
{
    public class addteam
    {
        [Required(ErrorMessage = "Name is mandatory and can be 30 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manager is mandatory and can be 50 chars")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "Contact Number only allows numbers")]
        public string Contact { get; set; }


    }
}

