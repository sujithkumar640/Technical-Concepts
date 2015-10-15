using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcWebServiceClientApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //CalculatorWebServiceSoapClient converting asp.net result into soap format //
            CalculatorWebService.CalculatorWebServiceSoapClient client = new CalculatorWebService.CalculatorWebServiceSoapClient();
            int result = client.Add(Convert.ToInt32(txtFirst.Text), Convert.ToInt32(txtSecond.Text));
            // Convert.ToInt32(txtFirst.Text) convert soa[ response to asp.net result..
            lblResult.Text = result.ToString();
            gvCalc.DataSource = client.GetCalculations();
            gvCalc.DataBind();
            gvCalc.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}