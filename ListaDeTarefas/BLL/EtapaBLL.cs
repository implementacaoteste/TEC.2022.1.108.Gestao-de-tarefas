using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public void AdicionarEtapa(Etapa _etapaBLL, int _idTarefa, int _value)
        {
            new EtapaDAL().AdicionarEtapa(_etapaBLL, _idTarefa, _value);
        }
        public void AlterarEtapa(Etapa _etapaBLL)
        {
            new EtapaDAL().AlterarEtapa(_etapaBLL);
        }
        public void ExcluirEtapa(int _id)
        {
            new EtapaDAL().ExcluirEtapa(_id);
        }
        public void StatusEtapa(int _idEtapa, int _score, int _idLista, bool _status)
        {
            if(_status== true)
            {
                _status = false;
                new EtapaDAL().StatusEtapaFalse(_idEtapa, _score, _idLista, _status);
            }
            else
            {
                _status = true;
                new EtapaDAL().StatusEtapaTrue(_idEtapa, _score, _idLista, _status);
            }
        }

    }
}