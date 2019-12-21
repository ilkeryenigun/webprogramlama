using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProgramlamaProjesi.Areas.Admin.Models
{
    public class SliderModel
    {
        public int SliderID { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderAciklama { get; set; }
        public Nullable<System.DateTime> BaslangicTarih { get; set; }
        public Nullable<System.DateTime> BitisTarih { get; set; }
        public HttpPostedFileBase Resim { get; set; }
    }
}