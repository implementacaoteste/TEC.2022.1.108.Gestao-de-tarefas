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
        public List<Etapa> BuscarPorIdEtapa(int IdEtapa)
        {
            return new EtapaDAL().BuscarPorIdEtapa(IdEtapa);
        }
        public List<Etapa> BuscarPorIdTarefa(int IdTarefa)
        {
            return new EtapaDAL().BuscarPorIdTarefa(IdTarefa);
        }
        public List<Etapa> BuscarPorIdUsuario(int IdUsuario)
        {
            return new EtapaDAL().BuscarPorIdUsuario(IdUsuario);
        }
        public void BuscarPorTodasEtapas(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.BuscarPorTodasEtapas(etapa);
        }
        public void BuscarPorNomeEtapa(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.BuscarPorNomeEtapa(etapa);
        }
        public void AdicionarEtapa(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.AdicionarEtapa(etapa);
        }
        public void AlterarEtapa(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.AlterarEtapa(etapa);
        }
        public void ExcluirEtapa(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.ExcluirEtapa(etapa);
        }
    }
}
