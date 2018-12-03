using System;

namespace PrimeiraAplicacao.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double NotaFinal { get; set; }
        public bool Aprovado { get; set; }
    }
}