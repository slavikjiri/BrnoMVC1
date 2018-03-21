using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BrnoMvc1.Business
{
    public class XmlActionResult : ActionResult
    {
        public Object my_obj { get; set; }

        public XmlActionResult(Object obj)
        {
            my_obj = obj;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(my_obj.GetType());
            context.HttpContext.Response.ContentType = "text/xml";
            ser.Serialize(context.HttpContext.Response.Output, my_obj);


            //throw new NotImplementedException();
        }
    }
}
