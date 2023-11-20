using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tabuleria_luderia.Models
{
    [Table("Clientes")]
    public class Cliente
    {      

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo de conta")]
        public Tipo Tipo { get; set; }
    }

    public enum Tipo
    {
        Lojista,
        Jogador
    }
}
