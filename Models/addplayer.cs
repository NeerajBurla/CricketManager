using System.ComponentModel.DataAnnotations;

namespace CricketManager.Models
{
    public class addplayer
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Age")]
        public string DateofBirth { get; set; }

        [Required]
        public Position? Position { get; set; }

        [Required]
        public string Captain { get; set; }

 
        [Required(ErrorMessage = "Batting Order between 1 and 11")]
        [Range(1, 11, ErrorMessage = "Batting Order between 1 and 11")]
        [Display(Name = "BattingOrder")]
        public int? BattingOrder { get; set; }

        [Required]
        public BowlingStyle? BowlingStyle { get; set; }

        [Required]
        public Rating? Rating { get; set; }



    }

    public enum Position
    {
        Batter,
        Bowler,
        Wicketkeeper,
    }
   
    public enum BowlingStyle
    {
        Fast,
        Medium,
        Spin,
    }
    public enum Rating
    {
        Excellent,
        Good,
        Average,
        Poor,
        Rubbish,
    }


}

