using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welding.DAL
{
    public class JobFields
    {
        public JobFields() { }

        public int PrimaryKey { get; set; } = -1;

        public string JobNo { get; set; } = "";
        public string PurchaseOrderNo { get; set; } = "";//SqlBaseField.Read<String>(reader, "j.porder");
        public string Client { get; set; } = "";// SqlBaseField.Read<String>(reader, "p.name");
        public string ItemDescription { get; set; } = "";// SqlBaseField.Read<String>(reader, "j.jobname");
        public string ClientManager { get; set; } = ""; // SqlBaseField.Read<String>(reader, "p2.name");
        public string Division { get; set; } = ""; // SqlBaseField.Read<String>(reader, "d.full_name");
    }
    public class PersonFields
    {
        public int PrimaryKey { get; set; }
        public string EmployeeNumber { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }

        public string EmployeeName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }

        public string WorkRole { get; set; }
        public string PhoneNumber { get; set; }

        public string Ext { get; set; }

        public string SpeedDial { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public string Lat { get; set; }
        public string Lon { get; set; }

        public string PhoneType { get; set; }

        //public Image Picture { get; set; }

        //From TimeStamp Event
        public DateTime LastSeen_DateTime { get; set; }
        public string LastSeen_Location { get; set; }



        public bool IsActive = true;


    }
}
