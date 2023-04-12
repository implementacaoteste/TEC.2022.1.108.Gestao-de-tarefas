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
            EtapaDALcs etapaDALcs = new EtapaDALcs();
            etapaDALcs.AdicionarEtapa();
        }
        public void AlterarEtapa()
        {
            EtapaDALcs etapaDALcs = new EtapaDALcs();
            etapaDALcs.AlterarEtapa();
        }
        public void ExcluirEtapa()
        {
            EtapaDALcs etapaDALcs = new EtapaDALcs();
            etapaDALcs.ExcluirEtapa();
        }
    }
}
