using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CDK
{
    public partial class sql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetData();
        }
        public void GetData()
        {
            string cs = @"Data Source=HYD-DEHARISH-L;Initial Catalog=cdk;Integrated Security=True";
            cdkDataContext cdkDb = new cdkDataContext(cs);
            GridView1.DataSource = cdkDb.cdk_users;
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=HYD-DEHARISH-L;Initial Catalog=cdk;Integrated Security=True";
            using (cdkDataContext cdkDb = new cdkDataContext(cs))
            {
                cdk_user cdkUser = new cdk_user
                {
                    FirstName="Yogita",
                    LastName="Jhiloria",
                    Email="yogita.jhiloria@cdk.com",
                    C_Password="123456"
                };
                cdkDb.cdk_users.InsertOnSubmit(cdkUser);
                cdkDb.SubmitChanges();
            }
            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=HYD-DEHARISH-L;Initial Catalog=cdk;Integrated Security=True";
            using (cdkDataContext cdkDb = new cdkDataContext(cs))
            {
                cdk_user cdkUser = cdkDb.cdk_users.SingleOrDefault(x => x.ID == 2);
                cdkUser.FirstName = "Rahul";
                cdkDb.SubmitChanges();

            }
            GetData();
        }
    }
}