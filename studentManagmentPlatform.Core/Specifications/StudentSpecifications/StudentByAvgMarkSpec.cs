using System.Linq.Expressions;
using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Specifications.StudentSpecifications;

public class StudentByAvgMarkSpec : Specification<Student>
{
    private readonly double _avgMark;

    public StudentByAvgMarkSpec(double avgMark)
    {
        _avgMark = avgMark;
    }
    public override Expression<Func<Student, bool>> ToExpression()
    {
        return s => s.StudentMarksDetails.Any() //prevent division 0
            && s.StudentMarksDetails.Average(sd => sd.AvgMark) >= _avgMark;
    }
}