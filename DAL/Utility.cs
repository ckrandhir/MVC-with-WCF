/*
* @author   TCS
* @version  MSO Version 1.0
* @since    19 May 2015
*
* Modification History:
*
* Issue Id			Date of Modification		Modified By				Changes Made
******************************************************************************************************************** 
SR#2015-05-05-0922     19 May 2015           Anurag Agarwal         FormatDateInOracleFormat

 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

using System.Web;

namespace Dal

{
    

    public static class Utility
    {
         
        public static readonly string SqlConnection = Convert.ToString(ConfigurationManager.ConnectionStrings["Test"]);


        public static string GetSQlConnection()
        {
            return SqlConnection;
        }


        public static DateTime ConvertToDateTime(object objVal)
        {
           
                return Convert.ToDateTime(objVal);
            
         

        }

        public static string FormatDate(object objDate, bool IsLong, bool IncludeTime)
        {
            string strFormat, strFormattedDate;
            strFormattedDate = "";
            if (IsLong)
                strFormat = "MMMM dd, yyyy";
            else
                strFormat = "MM/dd/yyy";

            if (IncludeTime)
                strFormat = string.Format("{0} HH:mm:ss", strFormat);

            try
            {
                DateTime dt = Convert.ToDateTime(objDate);
                strFormattedDate = dt.ToString(strFormat);
            }
            catch (Exception) { }

            return strFormattedDate;
        }

        public static string FormatDateInOracleFormat(object objDate)
        {
            string strFormat;
            string strFormattedDate;
            strFormat = "dd-MMM-yy";
            DateTime dateTime = Convert.ToDateTime(objDate);
            strFormattedDate = dateTime.ToString(strFormat);
            return strFormattedDate;
        }

        public static int ConvertToInt(object objVal)
        {
            int val = 0;
            try
            {
                val = Convert.ToInt32(objVal);
            }
            catch (Exception) { }
            return val;
        }
        public static int ConvertToDecimal(object objVal)
        {
            int val = 0;
            try
            {
                val = Convert.ToInt32(objVal);
            }
            catch (Exception) { }
            return val;
        }

        #region Method To Fetch Column Value


        /// <summary>
        /// </summary>
        /// <param name="objValue">System.Object</param>
        /// <returns>System.Object</returns>
        public static object ReplaceValueWithDbNull(object objValue)
        {
            if (objValue == null)
                return System.DBNull.Value;
            else
                return objValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlDR">System.Data.SqlClient.SqlDataReader</param>
        /// <param name="strColumnName">System.String</param>
        /// <param name="defaultValue">T</param>
        /// <returns>T</returns>
        public static T ReplaceNull<T>(SqlDataReader sqlDR, string strColumnName, T defaultValue)
        {
            object obj;
            try
            {
                obj = sqlDR.GetValue(sqlDR.GetOrdinal(strColumnName));
            }
            catch
            {
                throw;
            }

            if (Convert.IsDBNull(obj))
                return defaultValue;
            else
            {
                return (T)ChangeType(obj, typeof(T));
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="dr">System.Data.DataRow</param>
        /// <param name="strColumnName">System.String</param>
        /// <param name="defaultValue">T</param>
        /// <returns>T</returns>
        public static T ReplaceNull<T>(DataRow dr, string strColumnName, T defaultValue)
        {
            object obj;
            try
            {
                obj = dr[strColumnName];
            }
            catch
            {
                throw;
            }

            if (Convert.IsDBNull(obj))
                return defaultValue;
            else
            {
                return (T)ChangeType(obj, typeof(T));
            }
        }



        /// <summary>
        /// </summary>
        /// <param name="value">System.Object</param>
        /// <param name="conversionType">System.Type</param>
        /// <returns>System.Object</returns>
        public static object ChangeType(object value, Type conversionType)
        {
            // Note: This if block was taken from Convert.ChangeType as is, and is needed here since we're
            // checking properties on conversionType below.
            if (conversionType == null)
            {
                throw new ArgumentNullException("conversionType");
            } // end if

            // If it's not a nullable type, just pass through the parameters to Convert.ChangeType

            if (conversionType.IsGenericType &&
              conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                // It's a nullable type, so instead of calling Convert.ChangeType directly which would throw a
                // InvalidCastException (per http://weblogs.asp.net/pjohnson/archive/2006/02/07/437631.aspx),
                // determine what the underlying type is
                // If it's null, it won't convert to the underlying type, but that's fine since nulls don't really
                // have a type--so just return null
                // Note: We only do this check if we're converting to a nullable type, since doing it outside
                // would diverge from Convert.ChangeType's behavior, which throws an InvalidCastException if
                // value is null and conversionType is a value type.
                if (value == null)
                {
                    return null;
                } // end if

                // It's a nullable type, and not null, so that means it can be converted to its underlying type,
                // so overwrite the passed-in conversion type with this underlying type
                NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            } // end if

            // Now that we've guaranteed conversionType is something Convert.ChangeType can handle (i.e. not a
            // nullable type), pass the call on to Convert.ChangeType
            return Convert.ChangeType(value, conversionType);
        }


        #endregion



       
    }
}
