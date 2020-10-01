using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{

    public class Jogador
    {
        private string Nome;
        private int Idade;
        private int Num;
        private double Altura;
        private int Nrm_Chuteira;
        private bool CriarOutro;


        public string getNome()
        {
            return Nome;
        }
        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        //GET SET ANO DE CRIACAO
        public int getIdade()
        {
            return Idade;
        }

        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }
        //GET SET NUM
        public int getNum()
        {
            return Num;
        }

        public void setNum(int Num)
        {
            this.Num = Num;
        }
        //GET SET Altura
        public double getAltura()
        {
            return Altura;
        }

        public void setAltura(double Altura)
        {
            this.Altura = Altura;
        }

        //GET SET Nrm Chuteira
        public int getNrm_Chuteira()
        {
            return Nrm_Chuteira;
        }

        public void setNrm_Chuteira(int Nrm_Chuteira)
        {
            this.Nrm_Chuteira = Nrm_Chuteira;
        }

        public string getCriarOutro()
        {
            return Nome;
        }
        public void setCriarOutro(string Nome)
        {
            this.Nome = Nome;
        }
        public Jogador(string nome, int idade, int num, double altura, int nrm_Chuteira)
        {
            Nome = nome;
            Idade = idade;
            Num = num;
            Altura = altura;
            Nrm_Chuteira = nrm_Chuteira;
        }
    }
}
