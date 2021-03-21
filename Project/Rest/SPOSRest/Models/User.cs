using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPOSRest.Models
{
    public class User
    {
        #region Properties
        public int pin { get; set; }
        int ID { get; set; }
        int job_title_id { get; set; }
        String FName { get; set; }
        String MName { get; set; }
        String LName { get; set; }
        String personal_id { get; set; }
        String address_no { get; set; }
        String postal_code { get; set; }
        String address_street { get; set; }
        char gender { get; set; }
        String email { get; set; }
        String hours_worked { get; set; }
        DateTime DOB { get; set; }
        double salary_per_hour { get; set; }
        int phone_no { get; set; }

        #endregion
    }
}