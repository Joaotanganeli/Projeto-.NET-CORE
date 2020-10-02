using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{

    public class Jogador
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public int Num { get; set; }
        [Required]
        public float Altura { get; set; }
        [Required]
        public int Nmr_Chuteira { get; set; }


        /*public Jogador(string nome, int idade, int num, double altura, int nrm_Chuteira)
        {
            Nome = nome;
            Idade = idade;
            Num = num;
            Altura = altura;
            Nmr_Chuteira = nrm_Chuteira;
        }
        */

        public Jogador()
        {
        }
    }
}
