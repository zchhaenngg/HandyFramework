using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Handy.Framework.Extensions;

namespace Handy.Framework.System
{
    /// <summary>
    /// type conversion
    /// </summary>
    public class HandyConvert
    {
        /// <summary>
        /// Converts the item to an equivalent T value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static T ConvertTo<T>(object item)
        {
            return (T)ConvertTo(item, typeof(T));
        }
        /// <summary>
        /// Converts the item to an equivalent destination type value by using Convert.ChangeType method.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object ConvertTo(object value, Type type)
        {
            if (value == null)
            {
                if (type.IsNullable())
                {
                    return null;
                }
                else
                {
                    throw new InvalidCastException(string.Format("转换失败，空对象无法转换成不可空类型 {0}", type.Name));
                }
            }
            else
            {
                if (type.IsValueType)
                {
                    if (type.IsNullableGeneric())
                    {
                        type = Nullable.GetUnderlyingType(type);
                    }//ChangeType转换如 32->int?类型会失败
                    return Convert.ChangeType(value, type);
                }
                else
                {
                    return Convert.ChangeType(value, type);
                }
            }
        }

        /// <summary>
        /// 将集合转换成指定类型的List集合
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="coll"></param>
        /// <returns></returns>
        public static List<TValue> ToList<TValue>(IEnumerable coll)
        {
            if (coll == null)
            {
                return null;
            }
            else
            {
                var list = new List<TValue>();
                foreach (var item in coll)
                {
                    var t = ConvertTo<TValue>(item);
                    list.Add(t);
                }
                return list;
            }
        }

        public static dynamic ToList(IEnumerable coll, Type valueType)
        {

            if (valueType.IsValueType)
            {
                if (valueType.IsShort())
                {
                    return ToList<short>(coll);
                }
                else if (valueType.IsNShort())
                {
                    return ToList<short?>(coll);
                }
                else if (valueType.IsInt())
                {
                    return ToList<int>(coll);
                }
                else if (valueType.IsNInt())
                {
                    return ToList<int?>(coll);
                }
                else if (valueType.IsDouble())
                {
                    return ToList<double>(coll);
                }
                else if (valueType.IsNDouble())
                {
                    return ToList<double?>(coll);
                }
                else if (valueType.IsFloat())
                {
                    return ToList<float>(coll);
                }
                else if (valueType.IsNFloat())
                {
                    return ToList<float?>(coll);
                }
                else if (valueType.IsDateTime())
                {
                    return ToList<DateTime>(coll);
                }
                else if (valueType.IsNDateTime())
                {
                    return ToList<DateTime?>(coll);
                }
                else if (valueType.IsLong())
                {
                    return ToList<long>(coll);
                }
                else if (valueType.IsNLong())
                {
                    return ToList<long?>(coll);
                }
                else if (valueType.IsChar())
                {
                    return ToList<char>(coll);
                }
                else if (valueType.IsNChar())
                {
                    return ToList<char?>(coll);
                }
                else if (valueType.IsByte())
                {
                    return ToList<byte>(coll);
                }
                else if (valueType.IsNByte())
                {
                    return ToList<byte?>(coll);
                }
                else if (valueType.IsDecimal())
                {
                    return ToList<decimal>(coll);
                }
                else if (valueType.IsNDecimal())
                {
                    return ToList<decimal?>(coll);
                }
                else if (valueType.IsBool())
                {
                    return ToList<bool>(coll);
                }
                else if (valueType.IsNBool())
                {
                    return ToList<bool?>(coll);
                }
                else
                {
                    throw new NotSupportedException(valueType.Name);
                }
            }
            else
            {
                if (valueType.IsString())
                {
                    return ToList<string>(coll);
                }
                else
                {
                    if (coll == null)
                    {
                        return null;
                    }
                    else
                    {
                        var list = new List<dynamic>();
                        foreach (var item in coll)
                        {
                            list.Add(item);
                        }
                        return list;
                    }
                }
            }
        }
    }
}
