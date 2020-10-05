using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.NET.Models
{



    public class Time
    {
        public string Nome { get; }
        [Required]
        public int Ano_de_Criacao { get; }
        [Required]
        public int Qnt_Titulos { get; }
        [Required]
        public string Titulos { get; }



        public Time(string nome, int ano_de_criacao, int qnt_titulos, string titulos )
        {
            Nome = nome;
            Ano_de_Criacao = ano_de_criacao;
            Qnt_Titulos = qnt_titulos;
            Titulos = titulos;
        }
        

        private Time() { }

            private static Time objetoUnico;

            public static Time getInstance(string nome, int ano_de_criacao, int qnt_titulos, string titulos)
            {
                if (objetoUnico == null)
                    objetoUnico = new Time(nome , ano_de_criacao, qnt_titulos, titulos );
                return objetoUnico;
            }
        }
}
