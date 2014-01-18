using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace test_web
{
    /// <summary>
    /// Summary description for service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class service : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public List<int> RandomIntegers(int min, int max, int numberOfInts)
        {
            List<int> AllNumbers = new List<int>();

            Random r = new Random();

            for (int i = 0; i < numberOfInts; i++)
            {
                
                int randNum = r.Next(min, max);
                AllNumbers.Add(randNum);
            }

            return AllNumbers;
        }
    }
}
