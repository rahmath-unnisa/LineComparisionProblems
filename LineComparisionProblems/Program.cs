using LineComparisionProblems;

LineComparision length = new LineComparision(1, 2, 3, 4);
double line1 = length.CalculateLength();
string a = line1.ToString();
LineComparision line = new LineComparision(6, 7, 8 , 9);
double line2 = line.CalculateLength();
string b = line2.ToString();
if (a.Equals(b))
{
    Console.WriteLine("Both lines Length are equal");
}
else
    Console.WriteLine("lines are not equal"); 