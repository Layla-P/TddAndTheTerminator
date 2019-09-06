using TerminatorProcess.Models;

namespace TerminatorProcess.Services
{
    public class SubjectAnalyser : ISubjectAnalyser
    {
        public bool InvestigateFurther(ISubject subject)
        {
            if (subject.SubjectName == "woman")
            {
                return true;
            }

            if (subject.SubjectName == "boy")
            {
                return true;
            }
            return false;
        }
    }
}