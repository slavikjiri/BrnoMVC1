﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.Web.HtmlHelpers
{
    public static class DialogController
    {
        // GET: Dialog
        public static MvcHtmlString Modal(this HtmlHelper htmlHelper)
        {
            string BootStrapModal = @"
                    <button type = ""button"" class=""btn btn-info btn-lg"" data-toggle=""modal"" data-target=""#myModal"">Open Modal</button>
                    <div id = ""myModal"" class=""modal fade"" role=""dialog"">
                      <div class=""modal-dialog"">
                        <!-- Modal content-->
                        <div class=""modal-content"">
                          <div class=""modal-header"">
                            <button type = ""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                            <h4 class=""modal-title"">Modal Header</h4>
                          </div>
                          <div class=""modal-body"">
                            <p>Some text in the modal.</p>
                          </div>
                          <div class=""modal-footer"">
                            <button type = ""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                          </div>
                        </div>
                      </div>
                    </div>";
            return MvcHtmlString.Create(BootStrapModal);
        }
    }
}