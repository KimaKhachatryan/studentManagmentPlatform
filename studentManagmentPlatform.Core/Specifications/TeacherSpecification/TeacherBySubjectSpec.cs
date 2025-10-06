using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.TeacherSpecification
{
    public class TeacherBySubjectSpec : Specification<Teacher>
    {
        private readonly SubjectEnum? _subject;

        public TeacherBySubjectSpec(SubjectEnum? subject)
        {
            _subject = subject;
        }

        public override Expression<Func<Teacher, bool>> ToExpression()
        {
            return t => !_subject.HasValue ||
                        t.Subject == _subject.Value;
        }
    }
}
