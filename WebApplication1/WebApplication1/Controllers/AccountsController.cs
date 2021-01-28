﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeTest.Model;
using CodeTest.Business_Logic;

namespace CodeTest.Controllers
{
    public class AccountsController : ApiController
    {
        

        
        [Route("api/accounts/GetAccountPaymentDetails/{id}")]
        public AccountDetailModel Get(string id)
        {
            
                AccountPaymentDetails details = new AccountPaymentDetails();
                details.fillData();
                //check input format
                details.checkInputFormat(id);

                AccountDetailModel acctModel = details.GetAccountPaymentDetails(id);

                return acctModel;
            
            
        }

        
    }
}