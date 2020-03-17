using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Population1
    {
        int applicationId;
        int memberID;
        String firstname, middlename, lastname, suffix, gender;
        DateTime dOB;

        public int ApplicationId { get => applicationId; set => applicationId = value; }
        public int MemberID { get => memberID; set => memberID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }
    }
}