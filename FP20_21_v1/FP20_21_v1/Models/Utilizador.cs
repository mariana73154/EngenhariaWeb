using System.ComponentModel.DataAnnotations;

namespace FP20_21_v1.Models
{
    public class Utilizador
    {
        [Required(ErrorMessage ="Required Field")]
        public string Name;

        [Required(ErrorMessage ="Required Field")]
        [MinLength(5,ErrorMessage ="Password must have more then {0} characters")]
        [DataType(DataType.Password)]
        public string Password;

        [Required(ErrorMessage ="Required Field")]
        [DataType(DataType.EmailAddress)]
        public string Email;

        [Required(ErrorMessage ="Required Field")]
        public string Tipo;
    }
}
