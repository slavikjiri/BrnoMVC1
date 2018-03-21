using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoMvc1.Business.Extension
{
    public static class ControlExtension
    {
        public static XmlActionResult Xml(this System.Web.Mvc.Controller con, Object obj)
        {
            return new XmlActionResult(obj);
        }
    }
}
