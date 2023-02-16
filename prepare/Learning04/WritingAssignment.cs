using System;

namespace Learning04
{
    public class WritingAssigment : Assignment
    {
        private string _title;

    public WritingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
      _title = title;

    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        string info = $"{_title} {studentName}";

        return info;
    }

    }
}