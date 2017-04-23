using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Handy.Framework.Extensions;

namespace Handy.Framework.Expressions
{
    public static class Conditions
    {
        public static bool IsNull(object value) => value == null;
        public static bool IsNotNull(object value) => !IsNull(value);
        public static bool IsEmpty(object value)
        {
            if (value == null)
            {
                return true;
            }
            else
            {
                if (value is IEnumerable)
                {
                    foreach (var item in value as IEnumerable)
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    if (value.GetType().IsString())
                    {
                        return string.IsNullOrWhiteSpace(value as string);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static bool IsNotEmpty(object value) => !IsEmpty(value);
    }
}
