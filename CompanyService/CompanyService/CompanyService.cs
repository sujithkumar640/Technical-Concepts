﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicServiceChanged1, ICompanyConfidentialService
    {
        public string GetPubliInformation()
        {
            return "Public informaion available over HTTP";
        }

        public string GetConfidentialInformation()
        {
            return "Confidential informaion available over TCP behind the company firewall";
        }
    }
}
