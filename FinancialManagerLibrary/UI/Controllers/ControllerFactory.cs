using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.UI.Controllers
{
    public static class ControllerFactory 
    {
        // replace with a design pattern here
        public static IController GetController(string controller)
        {
            return controller switch
            {
                "Income" => new IncomeController(),
                "Expense" => new ExpenseController(),
                "Investment" => new InvestmentController(),
                "Reports" => new ReportController(),
                "User" => new UserController(),
                "Reminder" => new ReminderController(),
                "Notification" => new NotificationController(),
                "IncomeReminder" => new IncomeReminderController(),
                "IncomeNotification" => new IncomeNotificationController(),
                "ExpenseReminder" => new ExpenseReminderController(),
                "InvestmentReminder" => new InvestmentReminderController(),
                "Settings" => new SettingsController(),
                "StockAnalysis" => new StockAnalysisController(),                
            };
        }
    }
}
