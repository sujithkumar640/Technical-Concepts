using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDK
{
    public partial class webservicecall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator.WebService1SoapClient client =
                new Calculator.WebService1SoapClient();
            int result= client.Add(Convert.ToInt32(txtFirstNumber.Text),Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();

            gvCalculations.DataSource = client.GetCalculations();
            gvCalculations.DataBind();
            gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}