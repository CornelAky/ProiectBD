using System;
using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareAntrenor : IStocareAntrenor
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Antrenor> GetAntrenor()
        {
            var result = new List<Antrenor>();
            var dsJucatori = SqlDBHelper.ExecuteDataSet("select * from AD_BD_Antrenor", CommandType.Text);

            foreach (DataRow linieBD in dsJucatori.Tables[PRIMUL_TABEL].Rows)
            {
                var jucator = new Antrenor(linieBD);
                //incarca entitatile aditionale

                //jucator.Companie = new AdministrareCompanii().GetCompanie(masina.IdCompanie);
                result.Add(jucator);
            }
            return result;
        }
        public List<Antrenor> GetAntrenorLiberi()
        {
            var result = new List<Antrenor>();
            var dsJucatori = SqlDBHelper.ExecuteDataSet("select * from AD_BD_Antrenor where Id not in(select CoachID from AD_BD_Echipa)", CommandType.Text);

            foreach (DataRow linieBD in dsJucatori.Tables[PRIMUL_TABEL].Rows)
            {
                var jucator = new Antrenor(linieBD);
                //incarca entitatile aditionale

                //jucator.Companie = new AdministrareCompanii().GetCompanie(masina.IdCompanie);
                result.Add(jucator);
            }
            return result;
        }


        public Antrenor GetAntrenor(long id)
        {
            Antrenor result = null;
            var dsJucatori = SqlDBHelper.ExecuteDataSet("select * from AD_BD_Antrenor where ID = :IdMeci", CommandType.Text,
                new OracleParameter(":IdMeci", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsJucatori.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                try
                {
                    DataRow linieBD = dsJucatori.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                    result = new Antrenor(linieBD);

                   
                }
                catch(OracleException)
                {

                }

            }
            return result;
        }

        public bool AddAntrenor(Antrenor j)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into AD_BD_Antrenor VALUES (Sec_AD_BD.nextval, :Created_Date, :Name, :DATEOFBIRTH, :ContractStartDate, :ContractEndDate)", CommandType.Text,
            new OracleParameter(":Created_Date", OracleDbType.Date, DateTime.Now, ParameterDirection.Input),
                new OracleParameter(":Name", OracleDbType.NVarchar2, j.Name, ParameterDirection.Input),
                new OracleParameter(":DATEOFBIRTH", OracleDbType.Date, j.DateOfBirth, ParameterDirection.Input),
                new OracleParameter(":ContractStartDate", OracleDbType.Date, j.ContractStartDate, ParameterDirection.Input),
                new OracleParameter(":ContractEndDate", OracleDbType.Date, j.ContractEndDate, ParameterDirection.Input)
            );
        }

        public bool UpdateAntrenor(Antrenor m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE AD_BD_Antrenor set Name=:Name, DATEOFBIRTH=:DATEOFBIRTH where ID=:ID", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, m.Name, ParameterDirection.Input),
                new OracleParameter(":DATEOFBIRTH", OracleDbType.Date, m.DateOfBirth, ParameterDirection.Input),
                new OracleParameter(":ID", OracleDbType.Int32, m.ID, ParameterDirection.Input)
            );

        }
    }
}
