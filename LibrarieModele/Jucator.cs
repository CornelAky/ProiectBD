using System;
using System.Data;

namespace LibrarieModele
{
    public class Jucator :BaseObject
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long TeamID { get; set; }
        public string Position { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public double Salary { get; set; }

        public Echipa Team { get; set; }

        public Jucator(DataRow row)
        {
            ID = row["ID"] != DBNull.Value ? Convert.ToInt64(row["ID"]) : 0;
            Name = row["Name"] != DBNull.Value ? row["Name"].ToString() : string.Empty;
            DateOfBirth = row["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(row["DateOfBirth"].ToString()) : DateTime.MinValue;
            TeamID = row["PLAYERTEAMID"] != DBNull.Value ? Convert.ToInt64(row["PLAYERTEAMID"]) : 0;
            Position = row["Position"] != DBNull.Value ? row["Position"].ToString() : string.Empty;
            ContractStartDate = DateOfBirth = row["ContractStartDate"] != DBNull.Value ? Convert.ToDateTime(row["ContractStartDate"].ToString()) : DateTime.MinValue;
            ContractEndDate = DateOfBirth = row["ContractEndDate"] != DBNull.Value ? Convert.ToDateTime(row["ContractEndDate"].ToString()) : DateTime.MinValue;
            Salary = row["Salary"] != DBNull.Value ? Convert.ToDouble(row["Salary"]) : 0;
        }

        public Jucator(string name, DateTime dateOfBirth, long teamID, string position, DateTime contractStartDate, DateTime contractEndDate, double salary, Echipa team)
        {
            Name = name ;
            DateOfBirth = dateOfBirth;
            TeamID = teamID;
            Position = position ;
            ContractStartDate = contractStartDate;
            ContractEndDate = contractEndDate;
            Salary = salary;
            
        }

        public Jucator()
        {
        }
    }
}
