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
        public static List<TValue> ToList<TValue>(ICollection coll)
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

    }
}
