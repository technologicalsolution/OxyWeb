using OxyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OxyWeb.ViewModels
{
    public class ViewField : VError
    {
        public int Accion { get; set; }

        public List<Tfield> Lista { get; set; }

        public Tfield Modelo { get; set; }
    }
}
