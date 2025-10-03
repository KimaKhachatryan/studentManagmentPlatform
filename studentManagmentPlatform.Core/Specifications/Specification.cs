using System.Linq.Expressions;

namespace studentManagmentPlatform.Core.Specifications;

public abstract class Specification<T>
{
    public abstract Expression<Func<T, bool>> ToExpression();
}

//For building step by step the specifications
public class AndSpecification<T> : Specification<T>
{
    private readonly Specification<T> _left;
    private readonly Specification<T> _right;

    public AndSpecification(Specification<T> left, Specification<T> right)
    {
        _left = left;
        _right = right;
    }

    public override Expression<Func<T, bool>> ToExpression()
    {
        var leftExpr = _left.ToExpression();
        var rightExpr = _right.ToExpression();
        
        var parameterExpr = Expression.Parameter(typeof(T), "x");
        var leftBody = Expression.Invoke(leftExpr, parameterExpr);
        var rightBody = Expression.Invoke(rightExpr, parameterExpr);
        var andExpr = Expression.AndAlso(leftBody, rightBody);
        
        return Expression.Lambda<Func<T, bool>>(andExpr, parameterExpr);
    }
}

//The initial specification on which we will build the specifications
public class InitialSpecification<T> : Specification<T>
{
    public override Expression<Func<T, bool>> ToExpression() => _ => true;
}