using System;
using System.Collections.Generic;
using System.Text;

namespace VaporApp.Application.Requests
{
    public class UpdateUsersRequest
    {
        public int IdUser { get; set; }
        public string UserFirstName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserCountry { get; set; }
        public string UserZipcode { get; set; }
    }
}
