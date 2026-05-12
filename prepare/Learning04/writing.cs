using System;

class Writing : Assignment
{
    private string _assignmentName;
    
    public Writing(string studentName, string topic, string assignmentName) : base(studentName, topic)
    {
        _assignmentName = assignmentName;
    }

    public string GetWritingInformation()
    {
        return "Title: " + _assignmentName + " by " + GetStudentName();
    }
}