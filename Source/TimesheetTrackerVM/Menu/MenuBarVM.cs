using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TimesheetTrackerVM.Menu
{
    public class MenuBarVM : BaseVM
    {
        private bool isMenuExpanded = false;
        public bool IsMenuExpanded
        {
            get => isMenuExpanded;
            set => SetField(ref isMenuExpanded, value);
        }

        public void TriggerMenuExpand() => IsMenuExpanded = !IsMenuExpanded;
    }
}
