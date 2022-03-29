using System;
using System.Linq.Expressions;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region snippet_6
BinaryExpression be = Expression.Power(Expression.Constant(2D), Expression.Constant(3D));

Expression<Func<double>> le = Expression.Lambda<Func<double>>(be);

Func<double> compiledExpression = le.Compile();

double result = compiledExpression();

Console.WriteLine(result);
#endregion snippet_6
