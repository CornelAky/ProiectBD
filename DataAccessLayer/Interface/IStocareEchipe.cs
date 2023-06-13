using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareEchipe : IStocareFactory
    {
        List<Echipa> GetEchipe();
        Echipa GetEchipa(long id);
        bool AddEchipa(Echipa e);
        bool UpdateEchipa(Echipa e);
    }
}
