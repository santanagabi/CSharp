namespace ExemploConstrutores.Models
{
    public class Alunos : Pessoa
    {
        public Alunos(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe aluno");
        }        
    }
}