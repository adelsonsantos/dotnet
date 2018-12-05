using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeiraAplicacao.Models
{
    public class Aluno
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Nota Final")]
        public double NotaFinal { get; set; }
        public bool Aprovado { get; set; }
    }
}