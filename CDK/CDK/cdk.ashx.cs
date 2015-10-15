using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDK
{
    /// <summary>
    /// Summary description for cdk
    /// </summary>
    public class cdk : IHttpHandler
    {

       /* public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            HttpResponse r = context.Response;
            r.ContentType = "image/png";
            //
            // Write the requested image
            //
            string file = context.Request.QueryString["file"];
            if (file == "logo")
            {
                r.WriteFile("Desert.jpg");
            }
            else
            {
                r.WriteFile("Koala.jpg");
            }
        }
        public object GreetMe(string name)
        {
            return string.Format("Hello {0}!", name);
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }*/
        public void ProcessRequest(HttpContext context)
        {
            ManageForm(context);
        }

        public void ManageForm(HttpContext context)
        {
            context.Response.Write("<html><body><form>");

            context.Response.Write(
              "<h2>Hello there. What's cool about .NET?</h2>");
            context.Response.Write("<select name='Feature'>");
            context.Response.Write("<option> Strong typing</option>");
            context.Response.Write("<option> Managed code</option>");
            context.Response.Write("<option> Language agnosticism</option>");
            context.Response.Write("<option> Better security model</option>");
            context.Response.Write(
               "<option> Threading and async delegates</option>");
            context.Response.Write("<option> XCOPY deployment</option>");
            context.Response.Write(
               "<option> Reasonable HTTP handling framework</option>");
            context.Response.Write("</select>");
            context.Response.Write("</br>");
            context.Response.Write(
                "<input type=submit name='Lookup' value='Lookup'></input>");
            context.Response.Write("</br>");
            if (context.Request.Params["Feature"] != null)
            {
                context.Response.Write("Hi, you picked: ");
                context.Response.Write(context.Request.Params["Feature"]);
                context.Response.Write(" as your favorite feature.</br>");
            }

            context.Response.Write("</form></body></html>");
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}