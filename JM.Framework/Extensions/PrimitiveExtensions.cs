using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class PrimitiveExtensions
{
    /// <summary>
    /// Tries to perform null-safe parsing to long from string
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns>Parsed long value</returns>
    public static long ToLong(this string stringValue)
    {
        if (string.IsNullOrEmpty(stringValue))
        {
            return default(long);
        }
        else
        {
            return long.Parse(stringValue);
        }
    }

    /// <summary>
    /// Tries to perform null-safe parsing to integer from string
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns>Parsed integer value</returns>
    public static int ToInteger(this string stringValue)
    {
        if (string.IsNullOrEmpty(stringValue))
        {
            return default(int);
        }
        else
        {
            return int.Parse(stringValue);
        }
    }

    /// <summary>
    /// Tries to perform null-safe parsing to decimal from string
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns>Parsed decimal value</returns>
    public static decimal ToDecimal(this string stringValue)
    {
        if (string.IsNullOrEmpty(stringValue))
        {
            return default(decimal);
        }
        else
        {
            return decimal.Parse(stringValue);
        }
    }

    /// <summary>
    /// Tries to convert a string to decimal by detecting the seperator and converting to decimal accordingly
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns>Parsed decimal value</returns>
    public static decimal ToMoneyDecimal(this string stringValue)
    {
        if (string.IsNullOrEmpty(stringValue))
        {
            return default(decimal);
        }
        else
        {
            //detect seperator
            int dotCount = stringValue.Where(e => e == '.').Count();
            int commaCount = stringValue.Where(e => e == ',').Count();
            bool commaSeperated = true;
            string tenthsPlace = string.Empty;
            string decimalPlace = stringValue;
            if (dotCount > 1 && (commaCount == 0 || commaCount == 1))
            {
                commaSeperated = true;
            }
            else if (commaCount > 1 && (dotCount == 0 || dotCount == 1))
            {
                commaSeperated = false;
            }

            if (commaSeperated)
            {
                if (commaCount == 1)
                {
                    string[] splittedString = stringValue.Split(',');
                    decimalPlace = Regex.Replace(splittedString[0], ".", string.Empty);
                    tenthsPlace = splittedString[1];
                }
                else
                {
                    decimalPlace = Regex.Replace(decimalPlace, ".", string.Empty);
                    tenthsPlace = "00";
                }
            }
            else
            {
                if (dotCount == 1)
                {
                    string[] splittedString = stringValue.Split('.');
                    decimalPlace = Regex.Replace(splittedString[0], ",", string.Empty);
                    tenthsPlace = splittedString[1];
                }
                else
                {
                    decimalPlace = Regex.Replace(decimalPlace, ",", string.Empty);
                    tenthsPlace = "00";
                }
            }

            string parsedString = decimalPlace + CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator + tenthsPlace;
            return parsedString.ToDecimal();
        }
    }
}
