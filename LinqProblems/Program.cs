using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
            }

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var instructorNames = names.Distinct();
            foreach (var name in instructorNames)
            {
                Console.WriteLine(name);
            }


            // //Problem 3
            //take in list string of grade
            //convert list string to arrays?
            //convert to double
            //drop lowest grade from each array
            //orderby and remove first index[0]
            //average remaining grades from each string/array
            //average all averages(each string/array together)
            //expected output is 86.125
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55",
            };

            //var results = classGrades.Select(a =>a.Split(','));
            //var newNumbers = numbers.OrderBy(c => c);

            var gradeArray = classGrades.Select(c => c.Split(',').Select(double.Parse).OrderBy(g => g).Skip(1).Average()).ToList();
            var average = gradeArray.Average();



            //var gradeArray2 = classGrades.Select(c => c = "93,81,78,84,69").Select(c => c.Split(',')).ToArray.double.Parse(c => c.ToArray).OrderBy.Skip[0].Average.ToList();
            //var gradeArray3 = classGrades.Select(c => c = "73,88,83,99,64").Select(c => c.Split(',')).ToArray.OrderBy.Skip[0].Average.ToList();
            //var gradeArray4 = classGrades.Select(c => c = "98,100,66,74,55").Select(c => c.Split(',')).ToArray.OrderBy.Skip[0].Average.ToList();

            //List<string> classGrades;
            //foreach (var item in classGrades)
            //{
            //    var averageOfGrades = item.Split(',');
            //}



            //problem 4
            //write a function that takes in a string of letters (i.e., "Terrill") and returns an alphabetically ordered string corresponding to the letter frequency (i.e., "E1I1L2RrT1"

            Problem4 problem4 = new Problem4();
            problem4.CompressStringAndNumber("Terrill").OrderByDescending(p => p);
        }
    }
}

//Problem3 problem = new Problem3();
//problem.RemoveCommas();
//problem.SplitAtEveryTwoNumbers();
//double[] grades

//// //Problem 3
////take in list string of grade
////convert list string to arrays?
////convert to double
////drop lowest grade from each array
////orderby and remove first index[0]
////average remaining grades from each string/array
////average all averages(each string/array together)
////expected output is 86.125
//List<string> classGrades = new List<string>()
//            {
//                "80,100,92,89,65",
//                "93,81,78,84,69",
//                "73,88,83,99,64",
//                "98,100,66,74,55",
//            };
////string gradeArray = Convert.ToString(classGrades);

//// var gradeArray = classGrades.Split(",");
//string arrayToString = "";
//List<int> arrayOfInts = new List<int>();
//            foreach (string grades in classGrades)
//            {
//                //string[] tempGrades = grades.Split(",");
//                //grades.Split(,);
//                char[] tempArray = grades.ToArray();//80,100,92,89,65
//                for (int i = 0; i<tempArray.Length; i++)
//                {
//                    string tempString = tempArray[i].ToString();
//                    if (tempString == ",")
//                    {
//                        int tempInt = int.Parse(arrayToString);
//                        arrayOfInts.Add(tempInt);//need an int array to add this to
//                        arrayToString = "";
//                        continue;
//                    }
//                    arrayToString += tempString;
//                }
//                Console.WriteLine(tempArray[2]);//add back to array as pairing both
//            }
//            //gradeArray.Split(",");
//            var gradeArray = classGrades.Select(c => c = "80,100,92,89,65").Select(c => c.Split(",")).ToArray.OrderBy.Skip[0].Average;
//            //select
//            //orderbydesc
//            //toarray
//            //take

//            foreach (var item in classGrades)
//            {
//                var averageOfGrades = item.Split(",");
//            }