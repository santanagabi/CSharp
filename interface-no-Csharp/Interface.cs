using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);

        void Dono(string nomeDono);

        void Especie(string Especie);
    }
    class Animal : IAnimal
    {
        public string Nome { get; set; }

        public string nomeDono { get; set; }

        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie(string Especie)
        {
            this.Especie = Especie;
        }
    }
}