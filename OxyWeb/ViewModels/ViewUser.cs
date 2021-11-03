using OxyWeb.Models;
using System.Collections.Generic;

namespace OxyWeb.ViewModels
{
    public class ViewUser
    {
        public int Accion { get; set; }

        public List<VUser> Lista { get; set; }

        public TUser Modelo { get; set; }
    }
}
