using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace Webservice
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    /// Namespace is for uniquly identify the the service //
    [WebService(Namespace = "http://mycdk.com/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] autogenerate to binding with service//
    //for over loading of method we should change below line to [WebServiceBinding(ConformsTo = WsiProfiles.none)]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    //System.Web.Services.WebService important while enabling sessions
    public class CalculatorWebService : System.Web.Services.WebService
    {
        //if WeakReference don't decorate method with webmethod client will not be able to see that method';
        [WebMethod(EnableSession=true,Description="Calculation of two no",CacheDuration=20,MessageName="Calculate")]
        //here int is return type of method
        public int Add(int firstNumber,int secondNumber)
        {
            //return firstNumber + secondNumber;
            // If want to show all results histroy as well 
            List<string> calculations;
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string Result = firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(Result);
            Session["CALCULATIONS"] = calculations;
            return firstNumber + secondNumber;
        }

        //if WeakReference don't decorate method with webmethod client will not be able to see that method';
        [WebMethod(EnableSession = true, Description = "Calculation of three no", CacheDuration = 20, MessageName = "Calculate1")]
        //here int is return type of method
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            //return firstNumber + secondNumber;
            // If want to show all results histroy as well 
            List<string> calculations;
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string Result = firstNumber.ToString() + " + " + secondNumber.ToString() + "+" + thirdNumber.ToString() + " = " + (firstNumber + secondNumber + thirdNumber).ToString();
            calculations.Add(Result);
            Session["CALCULATIONS"] = calculations;
            return firstNumber + secondNumber;
        }

        [WebMethod(EnableSession = true)]
        //here int is return type of method
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
               return (List<string>)Session["CALCULATIONS"];
            }
        }
    }
}
// WSDL - webservice description language
// Client application calls the webservice which is called proxy class. Proxy class then serialize the parameters, 
//prepares a soap request messages and sends it to the webservice. The webservice executes the method and return soap response message to proxy, 
//proxy class then deserialize the soap message and hands in the client application