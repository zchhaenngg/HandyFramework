using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Handy.Framework.Expressions.Model;
using Handy.Framework.System;
using Handy.Framework.Extensions;

namespace Handy.Framework.Expressions
{
    public static class Lambdas
    {
        public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(ParameterExpression param, Lambda lambda)
        {
            var member = Expression.Property(param, lambda.PropertyName);
            switch (lambda.LambdaType)
            {
                case LambdaType.Equal:
                    return GetExpression<TEntity>(ExpressionType.Equal, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.NotEqual:
                    return GetExpression<TEntity>(ExpressionType.NotEqual, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.LessThan:
                    return GetExpression<TEntity>(ExpressionType.LessThan, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.LessThanOrEqual:
                    return GetExpression<TEntity>(ExpressionType.LessThanOrEqual, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.GreaterThan:
                    return GetExpression<TEntity>(ExpressionType.GreaterThan, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.GreaterThanOrEqual:
                    return GetExpression<TEntity>(ExpressionType.GreaterThanOrEqual, param, member, lambda.Value, lambda.PropertyType);
                case LambdaType.Like:
                    return GetLikeExpression<TEntity>(param, lambda, member);
                case LambdaType.Contain:
                    return GetContainExpression<TEntity>(param, lambda, member);
                case LambdaType.NotLike:
                case LambdaType.NotContain:
                default:
                    throw new NotSupportedException();
            }
        }

        private static Expression<Func<TEntity, bool>> GetContainExpression<TEntity>(ParameterExpression param, Lambda lambda, MemberExpression member)
        {
            if (lambda.Value is IEnumerable)
            {
                var convertValue = HandyConvert.ToList(lambda.Value as IEnumerable, lambda.PropertyType);
                var methodInfo = typeof(List<>).MakeGenericType(lambda.PropertyType).GetMethod("Contains");
                var body = Expression.Call(Expression.Constant(convertValue), methodInfo, member);
                return Expression.Lambda<Func<TEntity, bool>>(body, param);
            }
            else
            {
                throw new ArgumentException("Contain 只适用与数组、集合等容器");
            }
        }

        private static Expression<Func<TEntity, bool>> GetLikeExpression<TEntity>(ParameterExpression param, Lambda lambda, MemberExpression member)
        {
            var body = Expression.Call(member, typeof(string).GetMethod(nameof(string.Contains)), Expression.Constant(lambda.Value as string));
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        //public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(ParameterExpression param, params Lambda[] lambdas)
        //{

        //}

        private static Expression<Func<TEntity, bool>> GetExpression<TEntity>(ExpressionType expressionType, ParameterExpression param, MemberExpression member, dynamic value, Type propertyType)
        {
            var convertValue = HandyConvert.ConvertTo(value, propertyType);
            if (propertyType.IsNullable())
            {
                var binary = Expression.MakeBinary(expressionType, member, Expression.Convert(Expression.Constant(convertValue), propertyType));
                return Expression.Lambda<Func<TEntity, bool>>(binary, param);
            }
            else
            {
                var binary = Expression.MakeBinary(expressionType, member, Expression.Constant(convertValue));
                return Expression.Lambda<Func<TEntity, bool>>(binary, param);
            }
        }
    }
}
