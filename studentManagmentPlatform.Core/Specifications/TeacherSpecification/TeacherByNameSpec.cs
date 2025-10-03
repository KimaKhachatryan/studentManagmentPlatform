using System.Linq.Expressions;

namespace studentManagmentPlatform.Core.Specifications.TeacherSpecification;

public class TeacherByNameSpec : Specification<Teacher>
{
    private readonly string _name;

    public TeacherByNameSpec(string name)
    {
        _name = name.ToLower();
    }

    public override Expression<Func<Teacher, bool>> ToExpression()
    {
        return t => string.IsNullOrWhiteSpace(_name) ||
                    t.FirstName.ToLower().Contains(_name) ||
                    t.LastName.ToLower().Contains(_name);
    }
}