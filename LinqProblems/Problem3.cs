using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Problem3
    {

        //member variables
        public List<string> classGrades = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };
        //string grade;
        //constructor


        //member methods
        //var result = classGrades.Select(a => a.Split(",");
        //public double RemoveCommas()
        //{
        //    foreach (var item in classGrades)
        //    {
        //        var averageOfGrades = item.Split(",");
        //    }
        //    return averageOfGrades;
        //}
    }
}
//        public double RemoveCommas()
//{
//    foreach (string grade in classGrades)
//    {
//        grade.Replace(",", "");
//        grade.ToArray();
//        double result = double.Parse(grade);
//    }
//    return result;
//}
//public void SplitAtEveryTwoNumbers()
//{
//    for (int i = 0; i < grade.Length; i++)
//    {
//        int gradeSingle = (i + 1) + i;
//    }
//}