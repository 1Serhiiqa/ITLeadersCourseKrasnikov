﻿using NUnitFramework.Pages.AlertsFrameAndWindows;

namespace NUnitFramework.Navigation.LeftPanel.Groups.AlertsFrameAndWindows
{
    public class AlertsFrameAndWindowsGroup : BaseGroup
    {

        public AlertsPage Alerts() => NavigateTo<AlertsPage>("alerts");
    }
}
