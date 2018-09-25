using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace _20180917_FC_ASP_Demo_01
{
    public interface ILogger
    {
        void CreateLogMessages();
        
        void AddMessageToLog(string message);


         


    }
}