using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCsharpGama
{
    class Animal
    {
        private string nomeAnimal;
        private string tipoAnimal;


        public Animal(string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }
        public string getNome()
        {
            return this.nomeAnimal;
        }

        public void setNome(string nome)
        {
            this.nomeAnimal = nome;
        }

        public string getTipo()
        {
            return this.tipoAnimal;
        }

        public void setTipo(string tipo)
        {
            this.tipoAnimal = tipo;
        }
    }
}
