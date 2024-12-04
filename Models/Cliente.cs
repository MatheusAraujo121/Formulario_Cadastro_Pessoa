using System;
using System.ComponentModel.DataAnnotations;

namespace Formulario_Cadastro_Pessoa.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(150, ErrorMessage = "O nome completo deve ter no máximo 150 caracteres.")]
        public required string NomeCompleto { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2004", ErrorMessage = "A data de nascimento deve ser válida (não pode ser posterior a 1º de janeiro de 2004).")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório.")]
        [StringLength(20, ErrorMessage = "O RG deve ter no máximo 20 caracteres.")]
        [RegularExpression(@"^\d{1,2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "O RG deve estar no formato XX.XXX.XXX-X.")]
        public required string RG { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato XXX.XXX.XXX-XX.")]
        public required string CPF { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O logradouro deve ter no máximo 200 caracteres.")]
        public required string Logradouro { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O bairro deve ter no máximo 100 caracteres.")]
        public required string Bairro { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [StringLength(100, ErrorMessage = "A cidade deve ter no máximo 100 caracteres.")]
        public required string Cidade { get; set; }

        [StringLength(100, ErrorMessage = "O complemento deve ter no máximo 100 caracteres.")]
        public required string Complemento { get; set; }

        [Required(ErrorMessage = "A UF é obrigatória.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "A UF deve ter exatamente 2 caracteres.")]
        public required string UF { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(10, ErrorMessage = "O CEP deve ter no máximo 10 caracteres.")]
        public required string CEP { get; set; }

        [Required(ErrorMessage = "O estado civil é obrigatório.")]
        [StringLength(20, ErrorMessage = "O estado civil deve ter no máximo 20 caracteres.")]
        public required string EstadoCivil { get; set; }

        [Required(ErrorMessage = "O nome do pai é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do pai deve ter no máximo 100 caracteres.")]
        public required string NomePai { get; set; }

        [Required(ErrorMessage = "O nome da mãe é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da mãe deve ter no máximo 100 caracteres.")]
        public required string NomeMae { get; set; }

    }
}
