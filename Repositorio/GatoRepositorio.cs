using API_Petshop.Dao;
using API_Petshop.Model;

namespace API_Petshop.Repositorio
{
    public class GatoRepositorio
    {
        private readonly DaoGato _daoGato;

        public GatoRepositorio()
        {
            _daoGato = new DaoGato();
        }

        public List<Gato> GetGatos
        {
            get
            {
                return _daoGato.GetGatos();
            }
        }

        public void InserirGato(Gato gato)
        {
            _daoGato.InserirGato(gato);
        }

        public void AlterarGato(Gato gato)
        {
            _daoGato.AlterarGato(gato);
        }

        public void DeletarGato(int id)
        {
            _daoGato.DeletarGato(id);
        }

    }
}
