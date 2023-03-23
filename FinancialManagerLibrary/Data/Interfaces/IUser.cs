using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Data.Interfaces
{
    public interface IUser
    {
        long Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }
}
