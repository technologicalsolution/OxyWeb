using OxyWeb.Models;
using System.Collections.Generic;

namespace OxyWeb.ViewModels
{
    public class ViewEquipment : VError
    {
        public int Accion { get; set; }

        public List<VEquipment> Lista { get; set; }

        public TEquipment Modelo { get; set; }
    }
}
