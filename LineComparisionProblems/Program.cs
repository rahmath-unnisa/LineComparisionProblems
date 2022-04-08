using LineComparisionProblems;

LineComparision length = new LineComparision(1, 2, 3, 4);
double line1 = length.CalculateLength();
LineComparision line = new LineComparision(6, 7, 8 , 9);
double line2 = line.CalculateLength();
if (line1.CompareTo(line2) == 0)
{
    Console.WriteLine("Both lines Length are equal");
}
if (line2.CompareTo(line1) > 0)
{
    Console.WriteLine("lines1 is greater");
}
