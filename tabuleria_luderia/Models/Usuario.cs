using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tabuleria_luderia.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
       
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a senha")]
            [DataType(DataType.Password)]
            public string Senha { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o tipo de conta")]
            public Perfil Perfil { get; set; }
        

        }

        public enum Perfil
        {
            Admin,
            Lojista,
            Jogador
        }
    }

