using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FP18_19_v1.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Required Field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Data")]
        public DateTime DataRegisto { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public int NivelCliente { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
    }
}
