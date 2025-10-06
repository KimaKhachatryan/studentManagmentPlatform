using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.StudentSpecifications;

public class StudentByClassSpec : Specification<Student>
{
    private readonly string? _className;

    public StudentByClassSpec(string? className)
    {
        _className = className?.ToLower();
    }

    public override Expression<Func<Student, bool>> ToExpression()
    {
        return s => string.IsNullOrEmpty(_className) ||
                    s.Classroom.Name.ToLower().Contains(_className);
    }
}