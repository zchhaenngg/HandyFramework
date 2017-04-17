using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.System
{
    /// <summary>
    /// Decorated DateTime,Value representing the time after DateTime converted to UTC.
    /// </summary>
    public struct UTCTime
    {
        /// <summary>
        /// Decorate time
        /// </summary>
        /// <param name="time"></param>
        public UTCTime(DateTime time) : this()=> Value = time;

        private DateTime _datetime;
        /// <summary>
        /// UTC Time
        /// </summary>
        public DateTime Value
        {
            get
            {
                return _datetime;
            }
            set
            {

                if (value.Kind == DateTimeKind.Unspecified)
                {
                    if (value == DateTime.MinValue)
                    {
                        _datetime = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
                    }
                    else
                    {
                        throw new Exception("Failed to convert the value to UTC time,for the value's DateTimeKind is Unspecified!");
                    }
                }
                _datetime = value.ToUniversalTime();
            }
        }

        /// <summary>
        /// now
        /// </summary>
        public static UTCTime Now => new UTCTime(DateTime.UtcNow);

        /// <summary>
        /// Converting time implicitly to UTC
        /// </summary>
        /// <param name="time"></param>
        public static implicit operator UTCTime(DateTime time) => new UTCTime(time);
        /// <summary>
        /// Converting time implicitly to UTC
        /// </summary>
        /// <param name="time"></param>

        public static implicit operator UTCTime?(DateTime? time)
        {
            if (time == null)
            {
                return null;
            }
            else
            {
                return time.Value;
            }
        }
        /// <summary>
        /// Converting time implicitly to UTC.
        /// </summary>
        /// <param name="time"></param>
        public static explicit operator UTCTime(DateTime? time)
        {
            if (time == null)
            {
                throw new ArgumentNullException(nameof(time));
            }
            else
            {
                return time.Value;
            }

        }
        /// <summary>
        /// Gets the DateTime represented by UTCTime.
        /// </summary>
        /// <param name="time"></param>
        public static implicit operator DateTime(UTCTime time)=> time.Value;
        /// <summary>
        /// Gets the DateTime represented by UTCTime.
        /// </summary>
        /// <param name="time"></param>
        public static implicit operator DateTime? (UTCTime? time)=> time?.Value;
        /// <summary>
        /// Gets the DateTime represented by UTCTime.
        /// </summary>
        /// <param name="time"></param>
        public static explicit operator DateTime(UTCTime? time)
        {
            if (time == null)
            {
                throw new ArgumentNullException(nameof(time));
            }
            else
            {
                return time.Value;
            }

        }
    }
}
