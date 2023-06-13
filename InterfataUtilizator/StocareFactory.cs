using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;
using System.Drawing.Imaging;
using Oracle.DataAccess.Client;

namespace InterfataUtilizator
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":
                        try
                        {
                          
                            if (tipEntitate == typeof(Jucator))
                            {
                                return new AdministrareJucatori();
                            }
                            else if (tipEntitate == typeof(Antrenor))
                            {
                                return new AdministrareAntrenor();
                            }
                            else if (tipEntitate == typeof(Echipa))
                            {
                                return new AdministrareEchipe();
                            }
                            break;
                        }
                        catch (OracleException)
                        {
                            return null;
                        }

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
