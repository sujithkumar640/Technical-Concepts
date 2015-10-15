using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetHandlerDemo
{
    /// <summary>
    /// Summary description for First
    /// </summary>
    public class First : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "image/png";
            //context.Response.WriteFile("~/Flower1.png");
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            HttpResponse r = context.Response;
            //r.ContentType = "image/png";
            /*string file = context.Request.QueryString["file"];
            if (file == "logo")
            {
                r.WriteFile("Logo1.png");
            }
            else
            {
                r.WriteFile("Flower1.png");
            }*/
            r.ContentType = "text/plain";
            string txt = context.Request.QueryString["text"];
            if (txt != "")
            {
                r.Write("This is query string value :" + txt);
            }
            
            
        }
        //My reading indicates it can improve performance and decrease memory pressure by not repeatedly destroying the handler.
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}