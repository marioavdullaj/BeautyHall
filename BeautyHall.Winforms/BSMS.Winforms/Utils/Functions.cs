using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS.Winforms.GenericUtils
{
    public static class Functions
    {
        /// <summary>
        /// Converte un oggetto in stringa
        /// </summary>
        /// <param name="obj">oggetto da convertire</param>
        /// <returns></returns>
        public static string NullToString(this object? obj)
        {
            try
            {
                if (obj == null || DBNull.Value.Equals(obj))
                    return "";
                else
                    return obj.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        /// <summary>
        /// Converte un oggetto in booleano
        /// </summary>
        /// <param name="obj">oggetto da convertire</param>
        /// <returns></returns>
        public static bool NullToBool(this object? obj)
        {
            try
            {
                if (obj == null || DBNull.Value.Equals(obj))
                    return false;
                else
                    return System.Convert.ToBoolean(obj);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Converte un oggetto in double
        /// </summary>
        /// <param name="obj">oggetto da convertire</param>
        /// <returns></returns>
        public static double NullToDouble(this object? obj)
        {
            try
            {
                if (obj == null || DBNull.Value.Equals(obj))
                    return 0;
                else
                    return System.Convert.ToDouble(obj);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Converte un oggetto in intero
        /// </summary>
        /// <param name="obj">oggetto da convertire</param>
        /// <returns></returns>
        public static Int32 NullToInt(this object? obj)
        {
            try
            {
                if (obj == null || DBNull.Value.Equals(obj))
                    return 0;
                else
                    return System.Convert.ToInt32(obj);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Converte un oggetto in decimal
        /// </summary>
        /// <param name="obj">oggetto da convertire</param>
        /// <returns></returns>
        public static decimal NullToDecimal(this object? obj)
        {
            try
            {
                if (obj == null || DBNull.Value.Equals(obj))
                    return 0;
                else
                    return System.Convert.ToDecimal(obj);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Converte una string in float in base al CultureIfo
        /// </summary>
        /// <param name="number"></param>
        /// <param name="vs"></param>
        /// <returns></returns>
        public static decimal? StringToDecimalCulture(string number, System.Collections.Generic.List<char> vs)
        {
            decimal? result = null;

            try
            {
                if (vs == null || vs.Count == 0)
                {
                    vs.Add(',');
                    vs.Add('.');
                }

                System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CurrentCulture;
                System.Globalization.NumberFormatInfo dbNumberFormat = cultureInfo.NumberFormat;

                string output = System.Text.RegularExpressions.Regex.Replace(number, @"[\d-]", string.Empty);
                if (output.Length == 1)
                {
                    foreach (char item in vs)
                    {
                        if (item.Equals(output[0]))
                        {
                            number = number.Replace(output, dbNumberFormat.NumberDecimalSeparator);
                            result = decimal.Parse(number);
                        }
                    }
                }
                else if (output.Equals(""))
                {
                    result = decimal.Parse(number);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Converte un float in un decimal in base al CultureIfo
        /// </summary>
        /// <param name="number"></param>
        /// <param name="vs"></param>
        /// <returns></returns>
        public static float StringToFloatCulture(string number, System.Collections.Generic.List<char> vs)
        {
            float result = (float)StringToDecimalCulture(number, vs);
            return result;
        }
        /// <summary>
        /// Esportazione tabella su file csv
        /// </summary>
        /// <param name="sourceTable">tabella da esportare</param>
        /// <param name="charSep">carattere separatore</param>
        /// <param name="filePath">percorso e nome file</param>
        /// <param name="includeHeaders">visualizza header</param>
        /// <param name="quoteField">includi caratteri di quoting per stringhe</param>
        public static void WriteDataTable(DataTable sourceTable, string charSep, string filePath, bool includeHeaders, bool quoteField)
        {
            if (sourceTable != null && sourceTable.Rows.Count > 0)
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                {
                    if (includeHeaders)
                    {
                        System.Collections.Generic.IEnumerable<String> headerValues = sourceTable.Columns
                            .OfType<DataColumn>()
                            .Select(column => quoteField ? QuoteValue(column.ColumnName) : column.ColumnName);

                        writer.WriteLine(String.Join(charSep, headerValues));
                    }

                    System.Collections.Generic.IEnumerable<String> items = null;

                    foreach (DataRow row in sourceTable.Rows)
                    {
                        items = row.ItemArray.Select(o => quoteField ? QuoteValue(o?.ToString() ?? String.Empty) : (o?.ToString() ?? String.Empty));
                        writer.WriteLine(String.Join(charSep, items));
                    }

                    writer.Flush();
                }
            }
        }

        private static string QuoteValue(string value)
        {
            return String.Concat("\"",
            value.Replace("\"", "\"\""), "\"");
        }

    }
}
