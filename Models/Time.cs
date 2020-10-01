using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{
    public class Time
    {
        private string Nome;
        private int Ano_de_Criacao;
        private int Qnt_Titulos;

        //GET SET NOME
        public string getNome()
        {
            return Nome;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        ///--------------------------------------------------------------------///
        //GET SET ANO DE CRIACAO
        public int getAno_de_Criacao()
        {
            return Ano_de_Criacao;
        }

        public void setAno_de_Criacao(int Ano_de_Criancao)
        {
            this.Ano_de_Criacao = Ano_de_Criancao;
        }
        ///--------------------------------------------------------------------///

        //GET SET QNT DE TITULOS
        public int getQnt_Titulos()
        {
            return Qnt_Titulos;
        }

        public int setQnt_Titulos(int Qnt_Titulos)
        {
            return Qnt_Titulos;
        }
        ///--------------------------------------------------------------------///

        public Time(string nome, int Ano_de_Criacao, int Qnt_Titulos) 
        {
            this.Nome = nome;
            this.Ano_de_Criacao = Ano_de_Criacao;
            this.Qnt_Titulos = Qnt_Titulos;
        }
    }
}
