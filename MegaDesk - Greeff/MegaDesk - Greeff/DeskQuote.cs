using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Greeff
{
    internal class DeskQuote
    {
        //Attributes
        Desk _desk;
        int _rushDays;
        string _customerName;
        DateTime _quoteDate;

        // Constructors
        public DeskQuote(Desk desk, int rushDays, string customerName, DateTime quoteDate) {
            _desk = desk;
            _rushDays = rushDays;
            _customerName = customerName;
            _quoteDate = quoteDate;
        }

        // Methods
        public void DisplayQuote()
        {
           
        }
    }
}
