using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntendendoView.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Ó título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "O campo gênero é obrigatório")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "O valor deve ser de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        [Column(TypeName = "decimal(18,2")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage ="Preencha o campo avaliação")]
        [Display(Name ="Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Somente números")]
        public int Avaliacao { get; set; }








    }
}
