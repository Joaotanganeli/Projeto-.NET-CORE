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
        [Required]
        public string Posicao { get; set; }
    }
}
