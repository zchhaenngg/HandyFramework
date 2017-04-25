using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Handy.Framework.Expressions.Model;
using Handy.Framework.System;

namespace Handy.Framework.Expressions
{
    public static class Lambdas
    {
        //public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(ParameterExpression param, Lambda lambda)
        //{
        //    var member = Expression.Property(param, lambda.PropertyName);
        //    switch (lambda.LambdaType)
        //    {
        //        case LambdaType.Equal:
        //            break;
        //        case LambdaType.NotEqual:
        //            break;
        //        case LambdaType.LessThan:
        //            break;
        //        case LambdaType.LessThanOrEqual:
        //            break;
        //        case LambdaType.GreaterThan:
        //            break;
        //        case LambdaType.GreaterThanOrEqual:
        //            break;
        //        case LambdaType.Like:
        //            break;
        //        case LambdaType.NotLike:
        //            break;
        //        case LambdaType.Contain:
        //            {
        //                if (lambda.Value is IEnumerable)
        //                {
        //                    HandyConvert.ToList(lambda as IEnumerable)
        //                    var methodInfo = typeof(List<>).MakeGenericType(lambda.PropertyType).GetMethod("Contains");
        //                    var body = Expression.Call(Expression.Constant(lambda.Value), methodInfo, member);
        //                    return Expression.Lambda<Func<TEntity, bool>>(body, param);
        //                }
                        
        //            }
        //            break;
        //        case LambdaType.NotContain:
        //            break;
        //        default:
        //            break;
        //    }

        //    if (lambda is ContainLambda)
        //    {
        //        var methodInfo = lambda.Value.GetType().GetMethod("Contains");
        //        var body = Expression.Call(Expression.Constant(lambda.Value), methodInfo, member);
        //        return Expression.Lambda<Func<TEntity, bool>>(body, param);
        //    }
        //    else if (lambda is LikeLambda)
        //    {
        //        var body = Expression.Call(member, typeof(string).GetMethod(nameof(string.Contains)), Expression.Constant(lambda.Value as string));
        //        return Expression.Lambda<Func<TEntity, bool>>(body, param);
        //    }
        //    else
        //    {
        //        if (lambda.PropertyType.IsNullable())
        //        {
        //            var binary = Expression.MakeBinary(lambda.ExpressionType, member, Expression.Convert(Expression.Constant(lambda.Value), lambda.PropertyType));
        //            return Expression.Lambda<Func<TEntity, bool>>(binary, param);
        //        }
        //        else
        //        {
        //            var binary = Expression.MakeBinary(lambda.ExpressionType, member, Expression.Constant(lambda.Value));
        //            return Expression.Lambda<Func<TEntity, bool>>(binary, param);
        //        }
        //    }
        //}
        //public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(ParameterExpression param, params Lambda[] lambdas)
        //{
            
        //}
    }
}
