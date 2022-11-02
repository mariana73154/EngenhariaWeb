using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FP18_19_v2.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Descricao { get; set; }
        [DisplayName("Ficheiro")]
        public string CaminhoFicheiro { get; set; }
        public DateTime DataRegisto { get; set; }
        public int Gostos { get; set; }

    }

}
