//NumbersInCSharp tutorial from Microsoft completed by Jordan King on 06-05-2023

WorkWithIntegers();
OrderPrecedence();
TestLimits();
WorkWithDoubles();
UnderstandingDecimal();
areaOfCircle(2.50);

void WorkWithIntegers(){
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine("Addition");
    Console.WriteLine(c);
    c = a - b;
    Console.WriteLine("Subtraction");
    Console.WriteLine(c);
    c = a * b;
    Console.WriteLine("Multiplication");
    Console.WriteLine(c);
    c = a / b;
    Console.WriteLine("Division");
    Console.WriteLine(c);
}
void OrderPrecedence(){
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine("Standard Order Of Operations");
    Console.WriteLine(d);
    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine("Custom Order Of Operations w/Brackets");
    Console.WriteLine(d);
    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine("Dropped decimal Division");
    Console.WriteLine(h);
}
void TestLimits(){
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");
    int what = max + 3;
    Console.WriteLine($"An example of integer overflow: {what}");
}
void WorkWithDoubles(){
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);
    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}
void UnderstandingDecimal(){
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);
    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
}
void areaOfCircle(double rad){
    double area = Math.PI * (rad * rad);
    Console.WriteLine(area);
}