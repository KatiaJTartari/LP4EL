using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Helpers
{
    public static class HelperFrasePublicitaria
    {
        public static MvcHtmlString ExibeFrasePublicitaria(this HtmlHelper hp)
        {
            string str = "<h2> Viajar é investimento, escolher o local para se hospedar é necessidade </h2>";

            return new MvcHtmlString(str);
        }
    }
}