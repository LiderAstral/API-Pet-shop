using API_Petshop.Controllers;
using API_Petshop.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace API_Petshop.Dao
{
    public class DaoGato
    {
        //String de conexão com o banco de dados SQL Server que armazena os gatos da API
        string conexao = "Data Source=liderastral-server.database.windows.net;Initial Catalog=liderastral-database;Persist Security Info=True;User ID={meu user};Password={minha senha};Encrypt=True";

        //Função acionada através do método GET que retorna uma lista com todos os gatos do banco
        public List<Gato> GetGatos()
        {
            List<Gato> gatos = new List<Gato>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID_Gato, Nome, Cores, Tamanho, Peso, Nascimento, Temperamento FROM Gatos", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var gato = new Gato();
                                gato.ID_Gato = reader.GetInt32("ID_Gato");
                                gato.Nome = reader["Nome"].ToString();
                                gato.Cores = reader["Cores"].ToString();
                                gato.Tamanho = reader["Tamanho"].ToString();
                                gato.Peso = reader.GetDouble("Peso");
                                gato.Nascimento = reader["Nascimento"].ToString();
                                gato.Temperamento = reader["Temperamento"].ToString();
                                gatos.Add(gato);
                            }
                        }
                    }
                }
                conn.Close();
            }
            return gatos;
        }

        //Função acionada pelo método POST que armazena um gato novo no banco
        public void InserirGato(Gato gato)
        {

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Gatos (Nome, Cores, Tamanho, Peso, Nascimento, Temperamento) VALUES (@NOME, @CORES, @TAMANHO, @PESO, @NASCIMENTO, @TEMPERAMENTO)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", gato.Nome);
                    cmd.Parameters.AddWithValue("@CORES", gato.Cores);
                    cmd.Parameters.AddWithValue("@TAMANHO", gato.Tamanho);
                    cmd.Parameters.AddWithValue("@PESO", gato.Peso);
                    cmd.Parameters.AddWithValue("@NASCIMENTO", gato.Nascimento);
                    cmd.Parameters.AddWithValue("@TEMPERAMENTO", gato.Temperamento);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        
        //Função auxiliar para checar a existência de um gato específico no banco antes de tentar modificá-lo
        public bool GatoExiste(int id_gato)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Gatos WHERE ID_Gato = @IDGATO", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IDGATO", id_gato);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                            return true;
                        return false;
                    }
                }
            }
        }

        //Função acionada pelo método PUT que atualiza as informações de um gato no banco com um ID específico
        public void AlterarGato(Gato gato)
        {
            if (!GatoExiste(gato.ID_Gato))
                return;
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Gatos SET Nome = @NOME, Cores = @CORES, Tamanho = @TAMANHO, Peso = @PESO, Nascimento = @NASCIMENTO, Temperamento = @TEMPERAMENTO WHERE ID_Gato = @IDGATO", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IDGATO", gato.ID_Gato);
                    cmd.Parameters.AddWithValue("@NOME", gato.Nome);
                    cmd.Parameters.AddWithValue("@CORES", gato.Cores);
                    cmd.Parameters.AddWithValue("@TAMANHO", gato.Tamanho);
                    cmd.Parameters.AddWithValue("@PESO", gato.Peso);
                    cmd.Parameters.AddWithValue("@NASCIMENTO", gato.Nascimento);
                    cmd.Parameters.AddWithValue("@TEMPERAMENTO", gato.Temperamento);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        //Função acionada pelo método DELETE que exclui um gato fisicamente do banco
        public void DeletarGato(int id_gato)
        {
            if (!GatoExiste(id_gato))
                return;
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE Gatos WHERE ID_Gato = @IDGATO", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IDGATO", id_gato);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}