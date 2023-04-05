using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Models
{
    public class ModelInput 
    {
        public DateTime Date { get; set; }

        public float Year { get; set; }

        public float ClosingValue { get; set; }
    }
}
