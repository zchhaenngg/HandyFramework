using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.Extensions
{
    /// <summary>
    /// System.DateTime Extension
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// yyyy-MM-dd 23:59:59.999
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime ToDayMax(this DateTime dt) => dt.Date.AddDays(1).AddMilliseconds(-1);
        /// <summary>
        /// yyyy-MM-dd 23:59:59.999
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime? ToDayMax(this DateTime? dt) => dt?.ToDayMax();
    }
}
