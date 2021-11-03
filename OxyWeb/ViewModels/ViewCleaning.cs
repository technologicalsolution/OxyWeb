using OxyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OxyWeb.ViewModels
{
    public class ViewCleaning : VError
    {
        public int Accion { get; set; }

        public List<TCleaning> Lista { get; set; }

        public TCleaning Modelo { get; set; }
    }
}
