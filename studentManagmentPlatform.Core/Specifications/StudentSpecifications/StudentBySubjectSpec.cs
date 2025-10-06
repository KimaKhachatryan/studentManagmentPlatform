using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.StudentSpecifications;

public class StudentBySubjectSpec : Specification<Student>
{
    private readonly SubjectEnum? _subject;

    public StudentBySubjectSpec(SubjectEnum? subject)
    {
        _subject = subject;
    }

    public override Expression<Func<Student, bool>> ToExpression()
    {
        return s => !_subject.HasValue ||
                    s.StudentMarksDetails.Any(m => m.Subject == _subject);
    }
}