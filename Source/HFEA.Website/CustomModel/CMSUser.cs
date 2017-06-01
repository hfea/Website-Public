using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HFEA.Web.CustomModel
{   
    [Serializable()]
    public class CMSUser
    {
        private int id;
        private string name;
        private string email;

        public CMSUser(int intId, string strName, string strEmail)
        {
            this.id = intId;
            this.name = strName;
            this.email = strEmail;
        }
         
    }
}