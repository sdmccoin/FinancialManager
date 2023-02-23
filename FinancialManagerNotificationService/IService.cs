using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerNotificationService
{
    public interface IService
    {
        void CheckData();
        void Send(IMessage message);
    }
}
