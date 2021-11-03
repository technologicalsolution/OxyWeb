using OxyWeb.Models;
using System.Collections.Generic;

namespace OxyWeb.ViewModels
{
    public class ViewVendor : VError
    {
        public int Accion { get; set; }

        public List<Tvendor> Lista { get; set; }

        public Tvendor Modelo { get; set; }
    }
}
