using System;

int currentAssignments = 5;

int[] sophiaGrades = new int[] { 90, 86, 87, 98, 100};
int[] andrewGrades = new int[] { 92, 89, 81, 96, 90};
int[] emmaGrades = new int[] { 90, 85, 87, 98, 68};
int[] loganGrades = new int[] { 90, 95, 87, 88, 96};

var sophiaScore = getScore(sophiaGrades, currentAssignments);
var andrewScore = getScore(andrewGrades, currentAssignments);
var emmaScore = getScore(emmaGrades, currentAssignments);
var loganScore = getScore(loganGrades, currentAssignments);

var sophiaFinalGrade = getGrade(sophiaScore);
var andrewFinalGrade = getGrade(andrewScore);
var emmaFinalGrade = getGrade(emmaScore);
var loganFinalGrade = getGrade(loganScore);


Console.WriteLine("Student\t\tGrade\n");
printResults("Sophia", sophiaScore, sophiaFinalGrade);
printResults("Andrew", andrewScore, andrewFinalGrade);
printResults("Emma", emmaScore, emmaFinalGrade);
printResults("Logan", loganScore, loganFinalGrade);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


decimal getScore(int[] scoreGrades, int totalAssignments){
    int gradesSum = 0;

    foreach (int score in scoreGrades)
    {
        gradesSum += score;
    }

    return (decimal)gradesSum / totalAssignments;
}

string getGrade(decimal score){
    if (score >= 97)
        return "A+";
    else if (score >= 93)
        return "A";
    else if (score >= 90)
        return "A-";
    else if (score >= 87)
        return "B+";
    else if (score >= 83)
        return "B";
    else if (score >= 80)
        return "B-";
    else if (score >= 77)
        return "C+";
    else if (score >= 73)
        return "C";
    else if (score >= 70)
        return "C-";
    else if (score >= 67)
        return "D+";
    else if (score >= 63)
        return "D";
    else if (score >= 60)
        return "D-";
    else
        return "F";
}

void printResults(string studentName ,decimal studentScore, string studentFinalGrade){
    Console.WriteLine(studentName +"\t\t"+ studentScore +"\t\t"+ studentFinalGrade);
}