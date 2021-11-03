using OxyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OxyWeb.ViewModels
{
    public class ViewEvent : VError
    {
        public int Accion { get; set; }

        public List<TEvent> Lista { get; set; }

        public TEvent Modelo { get; set; }
    }
}
