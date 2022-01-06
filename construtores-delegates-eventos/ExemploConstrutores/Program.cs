using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores 
{
    public class Program
    {
        public delegate void Operacao(int x, int y);
        public static void Main(string[] args)
        {         
           //******** exemplo construtor ****************//
           Pessoa p1 = new Pessoa("Gabrielle", "Santana");
           p1.Apresentar();

           Alunos p1 = new Alunos("Gabrielle", "Santana", "Teste");
           p1.Apresentar();


           //*************** exemplo construtor privado e padrão singleton *******//
            Log log = Log.GetInstance();
            log.PropiedadeLog = "Teste Instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropiedadeLog);


            //************* Get e Set e propiedades ********* //
            Data data = new Data();
            //data.SetMes(20);

            data.Mes = 12;
            System.Console.WriteLine(data.Mes);

            data.ApresentarMes();

            //************* Exemplo Constante *********//
            const double pi = 3.14;
            System.Console.WriteLine(pi);

            //************* Exemplo Delegate **********//
            //Operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;

            op.Invoke(10, 10);
            //op(10,10);

            // ******** - Exemplo de Evento - ********
            Matematica m = new Matematica(10, 20);
            m.Somar();

        }
    }
}