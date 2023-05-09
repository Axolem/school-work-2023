using DataLayer;
using System.Data;
using System.Web.Services;

namespace LabEx5
{
    /// <summary>

    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        DataLayerClass dataLayer = new DataLayerClass();

        [WebMethod]
        public string Add(decimal numA, decimal numB)
        {
            decimal total = numA + numB;

            string data = $"{numA} + {numB} = {total}";
            dataLayer.SaveToDatabase(data);
            return data;
        }
        [WebMethod]
        public string Subtract(decimal numA, decimal numB)
        {
            decimal total = numA - numB;

            string data = $"{numA} - {numB} = {total}";
            dataLayer.SaveToDatabase(data);
            return data;
        }
        [WebMethod]
        public string Divide(decimal numA, decimal numB)
        {
            decimal total = numA / numB;

            string data = $"{numA} / {numB} = {total}";
            dataLayer.SaveToDatabase(data);
            return data;
        }
        [WebMethod]
        public string Multiply(decimal numA, decimal numB)
        {
            decimal total = numA * numB;

            string data = $"{numA} * {numB} = {total}";
            dataLayer.SaveToDatabase(data);
            return data;
        }
        [WebMethod]

        public DataTable getList()
        {

            DataTable table = dataLayer.ReadDataBase();
            table.TableName = "calculations";
            return table;
        }




    }
}
