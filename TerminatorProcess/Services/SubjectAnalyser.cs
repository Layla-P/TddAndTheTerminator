using TerminatorProcess.Models;

namespace TerminatorProcess.Services
{
    public class SubjectAnalyser :ISubjectAnalyser
    {
        public bool InvestigateFurther(ISubject subject)
        {
            if (subject.SubjectName == "woman")
            {
                return true;
            }
            return false;
        }
    }
}