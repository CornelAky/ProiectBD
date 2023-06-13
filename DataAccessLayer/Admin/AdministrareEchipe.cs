using LibrarieModele;
using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;

namespace NivelAccesDate
{
    public class AdministrareEchipe : IStocareEchipe
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Echipa> GetEchipe()
        {
            var result = new List<Echipa>();
            var dsEchipe = SqlDBHelper.ExecuteDataSet("select * from Team_OracleAC", CommandType.Text);

            foreach (DataRow linieBD in dsEchipe.Tables[PRIMUL_TABEL].Rows)
            {
                var echipa = new Echipa(linieBD);
                //incarca entitatile aditionale
                echipa.Coach = new AdministrareAntrenor().GetAntrenor(echipa.CoachID);
                result.Add(echipa);
            }
            return result;
        }

        public Echipa GetEchipa(long id)
        {
            Echipa result = null;
            var dsEchipe = SqlDBHelper.ExecuteDataSet("select * from Team_OracleAC where ID = :ID", CommandType.Text,
                new OracleParameter(":ID", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsEchipe.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsEchipe.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Echipa(linieBD);
                //incarca entitatile aditionale
                 result.Coach = new AdministrareAntrenor().GetAntrenor(result.CoachID);
            }
            return result;
        }

        public bool AddEchipa(Echipa j)
        {
            return SqlDBHelper.ExecuteNonQuery("insert into Team_OracleAC VALUES (Sec_AC.nextval, :Created_Date, :TEAM_NAME,:COACHID)", CommandType.Text,
            new OracleParameter(":Created_Date", OracleDbType.Date, DateTime.Now, ParameterDirection.Input),
                new OracleParameter(":TEAM_NAME", OracleDbType.NVarchar2, j.Team_Name, ParameterDirection.Input),
                new OracleParameter(":COACHID", OracleDbType.Int32, j.CoachID, ParameterDirection.Input)
            );
        }

        public bool UpdateEchipa(Echipa e)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Team_OracleAC set set TEAM_NAME=:TEAM_NAME, COACHID=:COACHID where ID=:ID", CommandType.Text,
            new OracleParameter(":TEAM_NAME", OracleDbType.NVarchar2, e.Team_Name, ParameterDirection.Input),
            new OracleParameter(":COACHID", OracleDbType.Int32, e.CoachID, ParameterDirection.Input),
            new OracleParameter(":ID", OracleDbType.Int32, e.ID, ParameterDirection.Input)
            );
        }
    }
}
