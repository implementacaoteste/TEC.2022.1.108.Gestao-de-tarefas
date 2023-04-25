using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EtapaBLL
    {
        public Etapa BuscarPorIdEtapa(int IdEtapa)
        {
            return new EtapaDAL().BuscarPorIdEtapa(IdEtapa);
        }
        public List<Etapa> BuscarPorIdUsuario(int IdUsuario)
        {
            return new EtapaDAL().BuscarPorIdUsuario(IdUsuario);
        }
        public List<Etapa> BuscarPorIdTarefa(int _id)
        {
            return new EtapaDAL().BuscarPorIdTarefa(_id);
        }
        public List<Etapa> BuscarPorNomeEtapa(string _nome)
        {
           return new EtapaDAL().BuscarPorNomeEtapa(_nome);
        }
        public void AdicionarEtapa(Etapa _etapa)
        {
            new EtapaDAL().AdicionarEtapa(_etapa);
        }
        public void AlterarEtapa(Etapa _etapa)
        {
            new EtapaDAL().AlterarEtapa(_etapa);
        }
        public void ExcluirEtapa(int _id)
        {
            new EtapaDAL().ExcluirEtapa(_id);
        }
    }
}
