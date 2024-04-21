using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.Utils.Extensions
{
    public static  class DataGridViewExtensions
    {

        public static string GetRowCellValue(this DataGridViewRow row,  string name) 
        {

            return row.Cells[name].Value.ToString();
        }




    }
}
