using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;

namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        string result = "";
        if (date.Length == 10) 
        {
            // Take day(dd)
            string day = date.Substring(0, 2);

            // Take month (mm)
            string month = date.Substring(3, 2);

            // Take year (yyyy)
            string year = date.Substring(6, 4);

            // Verify if the extractions are int values
            if (!(int.TryParse(day, out int intDay) &&
                int.TryParse(month, out int intMonth) &&
                int.TryParse(year, out int intYear)))
                {
                    return "Error : Invalid Format";
                } else {
                    result = date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
                }

        } else if (string.IsNullOrWhiteSpace(date))
        {
            result = "Error : Empty string";
        }
        else if (!(date.Length == 10))
        {
            result = "Error : Invalid Format";
        } 
        return result;
    } 
}
