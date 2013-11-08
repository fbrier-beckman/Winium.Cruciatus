﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindowFactory.cs" company="2GIS">
//   Cruciatus
// </copyright>
// <summary>
//   Представляет WindowFactory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cruciatus
{
    using System.Windows.Automation;

    public static class WindowFactory
    {
        public static AutomationElement GetMainWindowElement(string automationId)
        {
            var propertyCondition = new PropertyCondition(AutomationElement.AutomationIdProperty, automationId);
            var mainWindow = AutomationElement.RootElement.FindFirst(TreeScope.Children, propertyCondition);
            return mainWindow;
        }

        public static AutomationElement GetChildWindowElement(AutomationElement mainWindow, string headerName)
        {
            var propertyCondition = new PropertyCondition(AutomationElement.NameProperty, headerName);
            var window = mainWindow.FindFirst(TreeScope.Children, propertyCondition);
            return window;
        }
    }
}
