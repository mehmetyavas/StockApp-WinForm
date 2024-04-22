using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Utils.Extensions
{
    public static  class Alert
    {

        public static void Show(string msg, FormAlert.AlertType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }


    }
}
