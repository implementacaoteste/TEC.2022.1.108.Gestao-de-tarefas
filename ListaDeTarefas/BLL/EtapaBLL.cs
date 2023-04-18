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
        public void BuscarPorIdEtapa()
        {

        }
        public void BuscarPorIdUsuario()
        {

        }
        public void BuscarPorIdTarefa()
        {

        }
        public void BuscarPorTodasEtapas()
        {

        }
        public void BuscarPorNomeEtapa(Etapa etapa)
        {
            EtapaDAL etapaDAL = new EtapaDAL();
            etapaDAL.AdicionarEtapa(etapa);
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
