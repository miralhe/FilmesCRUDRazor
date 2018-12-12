using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeID { get; set; }

        [Display(Name = "Título")]
        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        //[Display(Name = "E-mail'")]
        //[Required]
        //[RegularExpression("/^[a-z0-9.]+@[a-z0-9]+\\.[a-z]+\\.([a-z]+)?$/i")]
        //public string email { get; set; }
    }
}
