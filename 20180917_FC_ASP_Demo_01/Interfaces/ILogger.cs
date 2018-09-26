using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace _20180917_FC_ASP_Demo_01
{
    interface ILogger
    {
        void CreateLogMessage(User user, Bot enemy);                  
    }
}