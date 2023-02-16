using System;

namespace Learning04
{
    public class MathAssigment : Assignment
    {
        private string _textBookSection;
        private string _problems;

        public MathAssigment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
        {
        _textBookSection = textBookSection;
        _problems = problems;
        }

        public string GetHomeworkList()
        {
            string homework = $"{_textBookSection} by {_problems}";
            return homework;
        }

    }
}