using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using SkiaSharp.Extended.UI.Controls;

namespace MauiWeather.Converters
{
    public class CodeToLottieConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            var code =(int)value;
            var lottieImage = new SKFileLottieImageSource();

            switch (code)
            {
                case 0:
                    lottieImage.File = "sunny.json"; break;

                case 1:
                case 2:
                case 3:
                    lottieImage.File = "cloudy.json"; break;

                case 45:
                case 48:
                    lottieImage.File = "foggy.json"; break;

                case 51:
                case 53:
                case 55:
                case 56:
                case 57:
                    lottieImage.File = "shower.json"; break;

                case 61:
                case 63:
                case 65:
                case 66:
                case 67:
                case 80:
                case 81:
                case 82:
                    lottieImage.File = "shower.json"; break;

                case 71:
                case 73:
                case 75:
                case 77:
                case 85:
                case 86:
                    lottieImage.File = "snow.json"; break;

                case 95:
                case 96:
                case 99:
                    lottieImage.File = "storm.json"; break;

                default:
                    lottieImage.File = "cloudy.json"; 
                    break;
            }

            return lottieImage;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
