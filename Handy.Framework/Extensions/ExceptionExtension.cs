using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.Extensions
{
    /// <summary>
    /// System.Exception Extension
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// Get the specified Exception T,from ex and the ex's InnerException,etc.
        /// </summary>
        public static T GetException<T>(this Exception ex)
            where T : Exception
        {
            if (ex is T)
            {
                return ex as T;
            }
            else
            {
                return ex.InnerException?.GetException<T>();
            }
        }
    }
}
