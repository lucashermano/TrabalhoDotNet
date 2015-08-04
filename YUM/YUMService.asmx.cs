using System;
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
    public class YUMService : System.Web.Services.WebService
    {
        [WebMethod]
        public Boolean UpdateCustomer(Custumer customer)
        {
            return true;
        }

        
    }
}
