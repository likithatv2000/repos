namespace ex3;
using System;
using System.Collections.Generic;
class ex3
{
    static void Main()
    {
        Dictionary<int, int> StudentList = new Dictionary<int, int>();


        StudentList.Add(10, 89);
        StudentList.Add(9, 90);
        StudentList.Add(4, 780);


        foreach (KeyValuePair<int, int> val in StudentList)
        {
            Console.WriteLine("StudentId: " + val.Key + " StudentMarks: " + val.Value);
        }
    }
}