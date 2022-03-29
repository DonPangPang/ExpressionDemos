using System.Reflection.Emit;
// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

#region snippet_1
// 表达式树
// Expression<Func<int, int>> e = x => x + 1;
// Expression<Func<int, bool>> lambda = num => num < 5;
#endregion snippet_1

#region snippet_2
// ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
// ConstantExpression five = Expression.Constant(5, typeof(int));
// BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
// Expression<Func<int, bool>> lambda = 
//     Expression.Lambda<Func<int, bool>>(
//         numLessThanFive, 
//         new ParameterExpression[] { numParam });
#endregion snippet_2

#region snippet_3
// ParameterExpression value = Expression.Parameter(typeof(int), "value");
// ParameterExpression result = Expression.Parameter(typeof(int), "result");
// LabelTarget label = Expression.Label(typeof(int));

// BlockExpression block = Expression.Block(
//     new[] { result },
//     Expression.Assign(result, Expression.Constant(0)),
//     Expression.Loop(
//         Expression.IfThenElse(
//             Expression.GreaterThan(value, Expression.Constant(1)),
//             Expression.MultiplyAssign(result, Expression.PostDecrementAssign(value)),
//             Expression.Break(label, result)
//         ),
//         label
//     )
// );

// int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);

// Console.WriteLine(factorial);
#endregion snippet_3

#region snippet_4
// Expression<Func<int, bool>> exprTree = num => num < 5;

// ParameterExpression  param = (ParameterExpression)exprTree.Parameters[0];
// BinaryExpression operation = (BinaryExpression)exprTree.Body;
// ParameterExpression left = (ParameterExpression)operation.Left;
// ConstantExpression  right = (ConstantExpression )operation.Right;

// Console.WriteLine("Decomposed  expression: {0} => {1} {2} {3}",
//     param.Name, left.Name, operation.NodeType, right.Value);
#endregion snippet_4

#region snippet_5
Expression<Func<int, bool>> expr = num => num < 5;
Func<int, bool> result = expr.Compile();
Console.WriteLine(result(4));

Console.WriteLine(expr.Compile()(4));
#endregion snippet_5
