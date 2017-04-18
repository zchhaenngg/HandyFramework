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
    public struct UTCTime: IConvertible
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

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Value;
        }

        public string ToString(IFormatProvider provider)
        {
            return Value.ToString();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
