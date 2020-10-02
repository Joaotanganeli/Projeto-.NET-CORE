using Microsoft.Data.SqlClient;
using Projeto_.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.NET.Models
{
    public class JogadorDALL
    {
        string connectionString = "Data Source=DESKTOP-5E0GEG5;Initial Catalog=JOGADORDB;Persist Security Info=False; User ID=sa;password=123;";

        //Mostrar todos

        public IEnumerable<Jogador> GetAllJogador()
        {
            List<Jogador> JList = new List<Jogador>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllJogador", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Jogador J1 = new Jogador();
                    J1.ID = Convert.ToInt32(dr["ID"].ToString());
                    J1.Nome = dr["Nome"].ToString();
                    J1.Altura = Convert.ToSingle(dr["Altura"].ToString());
                    J1.Num = Convert.ToInt32(dr["Numero"].ToString());
                    J1.Nmr_Chuteira = Convert.ToInt32(dr["Nmr_Chuteira"].ToString());

                    JList.Add(J1);
                }
                con.Close();
            }
            return JList;
        }
        //To inser Jogador
        public void AddJogador(Jogador J1)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertJogador", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", J1.Nome);
                cmd.Parameters.AddWithValue("@IDADE", J1.Idade);
                cmd.Parameters.AddWithValue("@ALTURA", J1.Altura);
                cmd.Parameters.AddWithValue("@NUMERO", J1.Num);
                cmd.Parameters.AddWithValue("@NMR_CHUTEIRA", J1.Nmr_Chuteira);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Para Atualizar jogador

        public void UpdateJogador(Jogador J1)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateJogador", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@JOGADOR_ID", J1.ID);
                cmd.Parameters.AddWithValue("@Nome", J1.Nome);
                cmd.Parameters.AddWithValue("@IDADE", J1.Idade);
                cmd.Parameters.AddWithValue("@ALTURA", J1.Altura);
                cmd.Parameters.AddWithValue("@NUMERO", J1.Num);
                cmd.Parameters.AddWithValue("@NMR_CHUTEIRA", J1.Nmr_Chuteira);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Deletar jogador
        public void DeleteJogador(int? J1Id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteJogador", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@JOGADOR_ID", J1Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Achar jogador pelo ID

        public Jogador GetJogadoresById(int? J1Id)
        {
            Jogador J1 = new Jogador();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetJogadorById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JOGADOR_ID", J1Id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    J1.ID = Convert.ToInt32(dr["ID"].ToString());
                    J1.Nome = dr["Nome"].ToString();
                    J1.Altura = Convert.ToSingle(dr["Altura"].ToString());
                    J1.Num = Convert.ToInt32(dr["Numero"].ToString());
                    J1.Nmr_Chuteira = Convert.ToInt32(dr["Nmr_Chuteira"].ToString());
                }
                con.Close();
            }
            return J1;
        }
    }
}
