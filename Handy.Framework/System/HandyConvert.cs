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
        ///  异常:
        ///   T:System.InvalidCastException:
        ///     不支持此转换。- 或 -value 是 null 并且 conversionType 是一个值类型。- 或 -value 不实现 System.IConvertible
        ///     接口。
        ///
        ///   T:System.FormatException:
        ///    value 的格式不是 conversionType 可识别的格式。
        ///
        ///   T:System.OverflowException:
        ///     value 表示不在 conversionType 的范围内的数字。
        ///
        ///   T:System.ArgumentNullException:
        ///     conversionType 为 null。
        public static T ConvertTo<T>(object item)
        {
            return (T)ConvertTo(item, typeof(T));
        }
        /// <summary>
        /// Converts the item to an equivalent destination type value.值类型需要实现IConvertible接口，非值类型返回自身。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        ///  异常:
        ///   T:System.InvalidCastException:
        ///     不支持此转换。- 或 -value 是 null 并且 conversionType 是一个值类型。- 或 -value 不实现 System.IConvertible
        ///     接口。
        ///
        ///   T:System.FormatException:
        ///    value 的格式不是 conversionType 可识别的格式。
        ///
        ///   T:System.OverflowException:
        ///     value 表示不在 conversionType 的范围内的数字。
        ///
        ///   T:System.ArgumentNullException:
        ///     conversionType 为 null。
        /// <returns></returns>
        protected static object ConvertTo(object value, Type type)
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
                var destination = type.GetUnderlyingType();
                if (destination.IsString())
                {
                    return value.ToString();
                }
                else
                {
                    if (!destination.IsValueType)
                    {
                        return value;
                    }
                    else
                    {
                        return Convert.ChangeType(value, destination);
                    }
                }
            }
        }

        /// <summary>
        /// 将集合转换成指定类型的List集合
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="coll"></param>
        /// <returns></returns>
        public static List<TValue> ToList<TValue>(ICollection coll)
        {
            if (coll == null)
            {
                return null;
            }
            else
            {
                var list = new List<TValue>();
                var isNullable = typeof(TValue).IsNullable();
                foreach (var item in coll)
                {
                    if (item == null)
                    {
                        if (isNullable)
                        {
                            list.Add(default(TValue));
                        }
                    }
                    else
                    {
                        var t = ConvertTo<TValue>(item);
                        list.Add(t);
                    }
                }
                return list;
            }
        }

    }
}
