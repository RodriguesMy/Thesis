using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Classes
{
    public class User
    {
        #region Properties
        public string ID { get; set; }
        public string jobTitle { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string personal_id { get; set; }
        public string address_no { get; set; }
        public string postal_code { get; set; }
        public string address_street { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public DateTime DOB { get; set; }
        public string salary_per_hour { get; set; }
        public string phone_no { get; set; }
        public bool is_active { get; set; }
        public bool is_manager { get; set; }
        public int working_minutes { get; set; }

        #endregion
    }
}
