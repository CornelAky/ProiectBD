using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareAntrenor : IStocareFactory
    {
        List<Antrenor> GetAntrenor();
        List<Antrenor> GetAntrenorLiberi();
        Antrenor GetAntrenor(long id);
        bool AddAntrenor(Antrenor m);
        bool UpdateAntrenor(Antrenor m);
    }
}
