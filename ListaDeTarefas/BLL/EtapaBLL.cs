using DAL;
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
        public void BuscarPorNomeEtapa()
        {

        }
        public void AdicionarEtapa()
        {
            EtapaDAL etapaDALcs = new EtapaDAL();
            etapaDALcs.AdicionarEtapa();
        }
        public void AlterarEtapa()
        {
            EtapaDAL etapaDALcs = new EtapaDAL();
            etapaDALcs.AlterarEtapa();
        }
        public void ExcluirEtapa()
        {
            EtapaDAL etapaDALcs = new EtapaDAL();
            etapaDALcs.ExcluirEtapa();
        }
    }
}
