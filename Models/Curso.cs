using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;

namespace ExemploExplorandoRevisando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAlunos(Pessoa aluno)
        {
            //Se aluno for removido será retornado true, caso não será retornado false
            return Alunos.Remove(aluno);
        }
        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso de: (Nome)");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}