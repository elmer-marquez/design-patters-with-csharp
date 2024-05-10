using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.One.SingleResponsabilityPrinciple.CReport
{
    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);
        public void RemoveEntryAt(int index)=>_entries.RemoveAt(index);

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries.Select(x=>$"Curso: {x.Name}, Estudiantes: {x.Students}, Valoracion: {x.Rating}"));
        }
    }
}