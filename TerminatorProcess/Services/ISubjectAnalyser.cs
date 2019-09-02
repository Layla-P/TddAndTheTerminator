using TerminatorProcess.Models;

namespace TerminatorProcess.Services
{
    public interface ISubjectAnalyser
    {
        bool InvestigateFurther(ISubject subject);
    }
}