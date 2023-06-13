using System;
using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareJucatori : IStocareJucatori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Jucator> GetJucatori()
        {
            var result = new List<Jucator>();
            var dsJucatori = SqlDBHelper.ExecuteDataSet("select * from AD_BD_Jucator", CommandType.Text);

            foreach (DataRow linieBD in dsJucatori.Tables[PRIMUL_TABEL].Rows)
            {
                var jucator = new Jucator(linieBD);
                jucator.Team = new AdministrareEchipe().GetEchipa(jucator.TeamID);
                result.Add(jucator);
            }
            return result;
        }

        public Jucator GetJucator(long id)
        {
            Jucator result = null;
            var dsJucatori = SqlDBHelper.ExecuteDataSet("select * from AD_BD_Jucator  where ID= :ID", CommandType.Text,
                new OracleParameter(":ID", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsJucatori.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsJucatori.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Jucator(linieBD);
                //incarca entitatile aditionale
                result.Team = new AdministrareEchipe().GetEchipa(result.TeamID);
            }
            return result;
        }

        public bool AddJucator(Jucator j)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into AD_BD_Jucator VALUES (Sec_AD_BD.nextval, :Created_Date, :Name, :DateOfBirth, :PlayerTeamID, :Position,:ContractStartDate, :ContractEndDate,:Salary)", CommandType.Text,
            new OracleParameter(":Created_Date", OracleDbType.Date,DateTime.Now, ParameterDirection.Input),
                new OracleParameter(":Name", OracleDbType.NVarchar2, j.Name, ParameterDirection.Input),
                new OracleParameter(":DateOfBirth", OracleDbType.Date,j.DateOfBirth, ParameterDirection.Input),
                new OracleParameter(":PlayerTeamID", OracleDbType.Int32, j.TeamID, ParameterDirection.Input),
                new OracleParameter(":Position", OracleDbType.NVarchar2, j.Position, ParameterDirection.Input),
                new OracleParameter(":ContractStartDate", OracleDbType.Date,j.ContractStartDate, ParameterDirection.Input),
                new OracleParameter(":ContractEndDate", OracleDbType.Date,j.ContractEndDate, ParameterDirection.Input),
                new OracleParameter(":Salary", OracleDbType.Double, j.Salary, ParameterDirection.Input)
            );
        }

        public bool UpdateJucator(Jucator j)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE AD_BD_Jucator set Name=:Name, DateOfBirth=:DateOfBirth, PlayerTeamID=:PlayerTeamID, Position=:Position,ContractStartDate=:ContractStartDate, ContractEndDate=:ContractEndDate,Salary=:Salary where ID = :ID", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, j.Name, ParameterDirection.Input),
                new OracleParameter(":DateOfBirth", OracleDbType.Date, j.DateOfBirth, ParameterDirection.Input),
                new OracleParameter(":PlayerTeamID", OracleDbType.Int32, j.TeamID, ParameterDirection.Input),
                new OracleParameter(":Position", OracleDbType.NVarchar2, j.Position, ParameterDirection.Input),
                new OracleParameter(":ContractStartDate", OracleDbType.Date, j.ContractStartDate, ParameterDirection.Input),
                new OracleParameter(":ContractEndDate", OracleDbType.Date, j.ContractEndDate, ParameterDirection.Input),
                new OracleParameter(":Salary", OracleDbType.Double, j.Salary, ParameterDirection.Input),
                 new OracleParameter(":ID", OracleDbType.Int32, j.ID, ParameterDirection.Input)
            );
        }
        public bool DeleteJucator(long id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "Delete from  AD_BD_Jucator where ID = :ID", CommandType.Text,
                 new OracleParameter(":ID", OracleDbType.Int32, id ,ParameterDirection.Input)
            );
        }
    }
}
