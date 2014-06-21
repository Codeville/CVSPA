using System.ComponentModel.DataAnnotations;

namespace CodeVille.SPA.UI.Models
{

    public class UserModel 
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Display(Name= "")]
        public string Username { get; set; }
        //[Required]
        //[Display(Name = "")]
        //[StringLength(100, ErrorMessage="err")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Display(Name = "confirm")]
        //[Compare("Password", ErrorMessage = "confirm error")]
        //[DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}