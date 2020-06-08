using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using TimesheetTrackerWPF.Converters.Generic;

namespace TimesheetTrackerWPF.Converters
{
    public sealed class BooleanToVisibilityConverter : GenericBooleanConverter<Visibility>
    {
        public BooleanToVisibilityConverter() : base(Visibility.Visible, Visibility.Collapsed)
        {
        }
    }
}
