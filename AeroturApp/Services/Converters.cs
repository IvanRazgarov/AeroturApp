using System.Globalization;
namespace AeroturApp.Services
{
    class StringSplitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is string)
            {
                var str = (string)value;
                var items = str.Split(',');
                if(parameter!=null)
                {
                    if (int.TryParse((string)parameter, out int par1))
                    {
                        return items[par1];
                    }
                    else
                    {
                        var par2 = (parameter as string);
                        var pars = par2.Split(",");
                        if (pars.Length >= 3 && bool.TryParse(pars[2], out bool doConvert))
                        {
                            if (doConvert) 
                            {
                                var condition = DateTime.TryParse(items[int.Parse(pars[0])], out DateTime dateTime);
                                TimeSpan.TryParse(items[int.Parse(pars[0])], out TimeSpan timeSpan);
                                return string.Format(pars[1], condition?dateTime:timeSpan);
                            }
                        }
                        return string.Format(pars[1], items[int.Parse(pars[0])]);
                    }
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var str = "";
            foreach (var item in (List<string>)value) { str += item; }
            return str;
        }
    }
}
