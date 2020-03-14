using System.Collections.Generic;

namespace zadanie_1
{
    public class StudiesManager
    {
        public static HashSet<Studies> Distinct(IEnumerable<Student> students)
        {
            var studies = new HashSet<Studies>(new StudiesComparator());
            foreach (var student in students)
            {
                studies.Add(student.Studies);
            }
            return studies;
        }

        private static Dictionary<Studies, int> CountForEach(IEnumerable<Studies> studies, IEnumerable<Student> students)
        {
            var studiesDictionary = new Dictionary<Studies, int>(new StudiesComparator());
            foreach (var study in studies)
            {
                studiesDictionary.Add(study, 0);
            }

            foreach (var student in students)
            {
                var study = student.Studies;
                studiesDictionary[study]++;
            }
            return studiesDictionary;
        }

        public static HashSet<Studies> UpdateNumberOfStudents(IEnumerable<Student> students)
        {
            var distinctStudies = Distinct(students);
            var studiesDictionary = CountForEach(distinctStudies, students);

            var activeStudies = new HashSet<Studies>();
            foreach (var study in studiesDictionary.Keys)
            {
                var activeStudy = new Studies()
                {
                    Major = study.Major,
                    NumberOfStudents = studiesDictionary[study]
                };
                activeStudies.Add(activeStudy);
            }
            return activeStudies;
        }
    }
}