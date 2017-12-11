using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ToolStats.Web.Corp
{
    public static class Configuration
    {
        public static string ApiServerPath => ConfigurationManager.AppSettings["ApiServerPath"];
        public static string AppSitePath => ConfigurationManager.AppSettings["AppSitePath"];
        public static string PaymentPortal => ConfigurationManager.AppSettings["PaymentPortal"];
    }
}