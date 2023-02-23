﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerNotificationService
{
    /// <summary>
    /// Service used to send email notifications
    /// </summary>
    public partial class ServiceEngine : ServiceBase
    {
        public ServiceEngine()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           // log onstart -> ServiceLogger 
        }

        protected override void OnStop()
        {
        }
    }
}
