using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.Expressions.Model
{
    public enum LambdaType
    {
        /// <summary>
        /// entity.a == 5
        /// </summary>
        Equal,
        /// <summary>
        /// entity.a != 5
        /// </summary>
        NotEqual,
        /// <summary>
        /// entity.a 小于 5
        /// </summary>
        LessThan,
        /// <summary>
        /// entity.a 小于等于 5
        /// </summary>
        LessThanOrEqual,
        /// <summary>
        /// entity.a > 5
        /// </summary>
        GreaterThan,
        /// <summary>
        /// entity.a >= 5
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// entity.a 的模糊查询
        /// </summary>
        Like,
        NotLike,
        /// <summary>
        /// 数组、集合。  如果是关于string的请使用LikeLambda
        /// </summary>
        Contain,
        NotContain
    }
}
