using System;
using System.Data;

namespace LibrarieModele
{
    public class Antrenor : BaseObject
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }

      
        public Antrenor(DataRow row)
        {
            this.ID = row["ID"] != DBNull.Value ? Convert.ToInt64(row["ID"]) : 0;
            this.Name = row["Name"] != DBNull.Value ? row["Name"].ToString() : string.Empty;
            this.DateOfBirth = row["DATEOFBIRTH"] != DBNull.Value ? Convert.ToDateTime(row["DATEOFBIRTH"].ToString()) : DateTime.MinValue;
            this.ContractStartDate = row["ContractStartDate"] != DBNull.Value ? Convert.ToDateTime(row["ContractStartDate"].ToString()) : DateTime.MinValue;
            this.ContractEndDate = row["ContractEndDate"] != DBNull.Value ? Convert.ToDateTime(row["ContractEndDate"].ToString()) : DateTime.MinValue;
        }

        public Antrenor(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public Antrenor()
        {
        }
    }
}
