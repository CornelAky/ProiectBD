using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareJucatori : IStocareFactory
    {
        List<Jucator> GetJucatori();
        Jucator GetJucator(long id);
        bool AddJucator(Jucator j);
        bool UpdateJucator(Jucator j);
        bool DeleteJucator(long id);
    }
}
