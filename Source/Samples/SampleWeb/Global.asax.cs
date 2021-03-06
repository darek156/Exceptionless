﻿#region Copyright 2014 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using System.Web;
using Exceptionless.Logging;

namespace Exceptionless.SampleWeb {
    public partial class Global : HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            ExceptionlessClient.Current.Log = new TraceExceptionlessLog();
            ExceptionlessClient.Current.UnhandledExceptionReporting += OnUnhandledExceptionReporting;
        }

        private void OnUnhandledExceptionReporting(object sender, UnhandledExceptionReportingEventArgs e) {
            // you can get access to the report here
            e.Error.Tags.Add("WebTag");
        }
    }
}