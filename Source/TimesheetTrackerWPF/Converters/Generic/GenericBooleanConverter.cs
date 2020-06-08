using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace TimesheetTrackerWPF.Converters.Generic
{
    public class GenericBooleanConverter<T> : IValueConverter
    {
        #region Public Constructors

        public GenericBooleanConverter(T trueValue, T falseValue)
        {
            True = trueValue;
            False = falseValue;
        }

        #endregion Public Constructors

        #region Public Properties

        public T False { get; set; }
        public T True { get; set; }

        #endregion Public Properties

        #region Public Methods

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool && ((bool)value) ? True : False;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T && EqualityComparer<T>.Default.Equals((T)value, True);
        }

        #endregion Public Methods
    }
}