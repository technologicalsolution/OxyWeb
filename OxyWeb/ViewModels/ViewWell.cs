using OxyWeb.Models;
using System.Collections.Generic;

namespace OxyWeb.ViewModels
{
    public class ViewWell : VError
    {
        public int Accion { get; set; }

        public List<VWell> Lista { get; set; }

        public TWell Modelo { get; set; }
    }
}
