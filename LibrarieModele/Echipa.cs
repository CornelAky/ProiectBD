using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Echipa : BaseObject
    {
        public string Team_Name { get; set; }
        public long CoachID { get; set; }
        public Antrenor Coach { get; set; }

        public Echipa(string Team_Name,long CoachID)
        {
            this.Team_Name = Team_Name;
            this.CoachID = CoachID;
        }

        public  Echipa(DataRow row)
        {
            ID = row["ID"] != DBNull.Value ? Convert.ToInt64(row["ID"]) : 0;
            Team_Name = row["Team_Name"] != DBNull.Value ? row["Team_Name"].ToString() : string.Empty;
            CoachID = row["CoachID"] != DBNull.Value ? Convert.ToInt64(row["CoachID"]) : 0;

        }

        public Echipa()
        {
        }

    }
}
