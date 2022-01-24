using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; } 

        [Required(ErrorMessage = " O Titulo é obrigatorio!!!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = " O Diretor é obrigatorio!!!")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = " O Genero é obrigatorio!!!")]
        public string Genero { get; set; }

        [Range(1, 600)]
        public int Duracao { get; set; }



    }
}
