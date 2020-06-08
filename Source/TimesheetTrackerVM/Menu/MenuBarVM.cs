using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TimesheetTrackerVM.Menu
{
    public class MenuBarVM : BaseVM
    {
        private bool isMenuCollapsed = true;
        public bool IsMenuCollapsed
        {
            get => isMenuCollapsed;
            set => SetField(ref isMenuCollapsed, value);
        }
    }
}
