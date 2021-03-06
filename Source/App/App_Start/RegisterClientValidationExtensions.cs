#region Copyright 2014 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using DataAnnotationsExtensions.ClientValidation;
using Exceptionless.App;
using WebActivator;

[assembly: PreApplicationStartMethod(typeof(RegisterClientValidationExtensions), "Start")]

namespace Exceptionless.App {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();
        }
    }
}