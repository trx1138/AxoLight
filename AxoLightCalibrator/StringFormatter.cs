﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AxoLightCalibrator
{
  class StringFormatter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, string language)
    {
      return (value as dynamic).ToString(parameter as string);
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotSupportedException();
    }
  }
}
