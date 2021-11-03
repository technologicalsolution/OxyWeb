using OxyWeb.Models;
using System.Collections.Generic;

namespace OxyWeb.ViewModels
{
    public class ViewLocation : VError
    {
        public int Accion { get; set; }

        public List<TLocation> Lista { get; set; }

        public TLocation Modelo { get; set; }
    }
}
