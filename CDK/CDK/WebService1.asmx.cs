using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CDK
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://cdk.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

       /* [WebMethod(EnableSession=true,Description="Calculation of two no.",CacheDuration=20)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;
            if (Session["CALCULATIONS"] == null)
            { 
                calculations=new List<string>();
            }
            else
            {
                 calculations= (List<string>)Session["CALCULATIONS"] ;
            }
            string strRecentCalculation=firstNumber.ToString()+ "+" + secondNumber.ToString()+ "= " + (firstNumber + secondNumber);
            calculations.Add(strRecentCalculation);
            Session["CALCULATIONS"]=calculations;
            return firstNumber + secondNumber;
        }*/
        //Method Overloading //
        [WebMethod(MessageName="Add2Num")]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        [WebMethod]
        public int Add(int firstNumber, int secondNumber,int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }
        //Method Overloading end//
        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not found any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }
    }
}
