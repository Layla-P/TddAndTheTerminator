using FluentAssertions;
using NUnit.Framework;
using TerminatorProcess.Models;
using TerminatorProcess.Services;

namespace TerminatorProcess.Tests
{
    [TestFixture]
    public class SubjectAnalyserTests
    {
        
        private ISubjectAnalyser _sut;
        
        
        [SetUp]
        public void Setup()
        {
            _sut = new SubjectAnalyser();
        } 
        
        
        //** Scan subjects and determine if they require further investigation **
        // - Scan subjects and see if they are of interest

        
        [TestCase("woman")]
        [TestCase("boy")]
        public void TerminatorShould_Determine_ToInvestigateFurther(string subjectName)
        {
            var subject = new Subject {SubjectName = subjectName};
            var result = _sut.InvestigateFurther(subject);

            result.Should().BeTrue();
        }
        
        
        [Test]
        public void TerminatorShould_DetermineNot_ToInvestigateFurther()
        {
            var subject = new Subject {SubjectName = "t1000"};
            var result = _sut.InvestigateFurther(subject);

            result.Should().BeFalse();
        }
    }
}