using System;
using Exceptionless.Models;

namespace Exceptionless.Core.Plugins {
    public interface IPlugin {
        void OnErrorStackCreated(PluginContext context, ErrorStack stack, Error error);
        void OnErrorOccurence(PluginContext context, Error error);
        void OnErrorStackRegression(PluginContext context, ErrorStack stack, Error error);
        void OnErrorStackPromoted(PluginContext context, ErrorStack stack);
        void OnErrorStackFixed(PluginContext context, ErrorStack stack);
    }
}
