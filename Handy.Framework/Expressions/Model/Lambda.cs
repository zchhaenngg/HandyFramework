using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Handy.Framework.Expressions.Model
{
    public class Lambda
    {
        public Type PropertyType { get; set; }
        public string PropertyName { get; set; }
        public LambdaType LambdaType { get; set; }
        public dynamic Value { get; set; }

        public Lambda(Type propertyType, string peopertyName, LambdaType lambdaType, dynamic value)
        {
            PropertyType = propertyType;
            PropertyName = peopertyName;
            LambdaType = lambdaType;
            Value = value;
        }
    }
}
