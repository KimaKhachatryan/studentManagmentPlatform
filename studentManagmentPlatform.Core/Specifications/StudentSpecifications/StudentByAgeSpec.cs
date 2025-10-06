using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.StudentSpecifications;

public class StudentByAgeSpec : Specification<Student>
{
    private readonly int _age;

    public StudentByAgeSpec(int age)
    {
        _age = age;
    }

    public override Expression<Func<Student, bool>> ToExpression()
    {
        return s => s.DateOfBirth <= DateTime.Now.AddYears(-_age);
    }
}