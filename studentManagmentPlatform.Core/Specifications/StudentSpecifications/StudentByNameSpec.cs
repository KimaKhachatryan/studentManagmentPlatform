using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.StudentSpecifications;

public class StudentByNameSpec : Specification<Student>
{
    private readonly string _name;

    public StudentByNameSpec(string name)
    {
        _name = name.ToLower();
    }

    public override Expression<Func<Student, bool>> ToExpression()
    {
        return s => string.IsNullOrWhiteSpace(_name) || 
                    s.FirstName.ToLower().Contains(_name) ||
                    s.LastName.ToLower().Contains(_name);
    }
}