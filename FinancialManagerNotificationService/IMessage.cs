using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerNotificationService
{
    public interface IMessage
    {
        TYPE Type { get; set; }
        string Title { get; set; }
        string Message { get; set; }
    }
}
