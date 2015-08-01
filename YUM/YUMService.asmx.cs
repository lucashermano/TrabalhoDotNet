using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ModeloCanonico;
namespace YUM
{
    /// <summary>
    /// Summary description for YUMService
    /// </summary>
    [WebService(Namespace = "http://br.pucminas/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class YUMService : System.Web.Services.WebService
    {
        [WebMethod]
        public Boolean UpdateCustomer(Custumer customer)
        {
            if (customer == null)
            {
                throw new Exception("fff");
            }
            return true;
        }

        
    }
}
