using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.Extensions
{
    /// <summary>
    /// System.Type Extension
    /// </summary>
    public static class TypeExtension
    {
        /// <summary>
        /// Whether type is string.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsString(this Type type) => type == typeof(string);
        /// <summary>
        /// Whether type is short.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsShort(this Type type) => type == typeof(short);
        /// <summary>
        /// Whether type is short?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNShort(this Type type) => type == typeof(short?);
        /// <summary>
        /// Whether type is int.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsInt(this Type type) => type == typeof(int);
        /// <summary>
        /// Whether type is int?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNInt(this Type type) => type == typeof(int?);
        /// <summary>
        /// Whether type is double.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsDouble(this Type type) => type == typeof(double);
        /// <summary>
        /// Whether type is double?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNDouble(this Type type) => type == typeof(double?);
        /// <summary>
        /// Whether type is float.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsFloat(this Type type) => type == typeof(float);
        /// <summary>
        /// Whether type is float?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNFloat(this Type type) => type == typeof(float?);
        /// <summary>
        /// Whether type is DateTime
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsDateTime(this Type type) => type == typeof(DateTime);
        /// <summary>
        /// Whether type is DateTime?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNDateTime(this Type type) => type == typeof(DateTime?);
        /// <summary>
        /// Whether type is long
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsLong(this Type type) => type == typeof(long);
        /// <summary>
        /// Whether type is long?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNLong(this Type type) => type == typeof(long?);
        /// <summary>
        /// Whether type is char
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsChar(this Type type) => type == typeof(char);
        /// <summary>
        ///  Whether type is char?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNChar(this Type type) => type == typeof(char?);
        /// <summary>
        /// Whether type is byte
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsByte(this Type type) => type == typeof(byte);
        /// <summary>
        /// Whether type is byte?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNByte(this Type type) => type == typeof(byte?);
        /// <summary>
        /// Whether type is decimal
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsDecimal(this Type type) => type == typeof(decimal);
        /// <summary>
        /// Whether type is decimal?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNDecimal(this Type type) => type == typeof(decimal?);
        /// <summary>
        /// Whether type is bool
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsBool(this Type type) => type == typeof(bool);
        /// <summary>
        /// Whether type is bool?.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNBool(this Type type) => type == typeof(bool?);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsNullable(this Type type) => !type.IsValueType || type.Name.Equals(typeof(Nullable<>).Name);
        /// <summary>
        /// 返回指定的可空类型的基础类型参数。
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetUnderlyingType(this Type type)
        {
            if (type.IsNullable())
            {
                return Nullable.GetUnderlyingType(type);
            }
            return type;
        }
    }
}
