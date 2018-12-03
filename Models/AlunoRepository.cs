using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeiraAplicacao.Models
{
    public static class AlunoRepository
    {
        private static IList<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "Adelson",
                NotaFinal = 8,
                Aprovado = true
            },
            new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "Jorge",
                NotaFinal = 10,
                Aprovado = true
            },
            new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "Lucas",
                NotaFinal = 5,
                Aprovado = false
            }
        };

        public static IEnumerable Getall()
        {
            return alunos;
        }
    }
}