using System.ComponentModel.DataAnnotations;

namespace Formulario_Cadastro_Pessoa.Models
{
    public class Cliente
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
        [Required]
        [StringLength (50)]
        public string NomePai { get; set;}
    }
}
