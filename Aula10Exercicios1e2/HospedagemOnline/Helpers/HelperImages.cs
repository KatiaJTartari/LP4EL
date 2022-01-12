using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Helpers
{
    public static class HelperImages
    {
        public static MvcHtmlString ExibeImagens(this HtmlHelper hp)
        {
            string str = "<div style='width:100%; text-align:center; padding:10px'>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/boutique-hotel.png' /></div>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/Cama-de-hotel.png' /></div>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/golden-lis_buffet.png' /></div>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/Hotel-Casa-de-Areia.png' /></div>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/unnamed.png' /></div>" +
                         "<div style='width:300px; height:168px; margin:5px; display:inline-block'> " +
                         "<img src='Images/villa-boa-vista-sol.png' /></div>" +
                         "</div>";

            return new MvcHtmlString(str);
        }
    }
}