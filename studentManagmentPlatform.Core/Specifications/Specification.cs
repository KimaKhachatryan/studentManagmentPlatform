using System.Linq.Expressions;

namespace studentManagmentPlatform.Core.Specifications;

public abstract class Specification<T>
{
    public abstract Expression<Func<T, bool>> ToExpression();
    
}