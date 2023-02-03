int Promt(string msg)
{
    System.Console.Write($"{msg}: ");
    return int.Parse(Console.ReadLine());
}

double k1 = Promt("Put k1");
double k2 = Promt("Put k2");
double b1 = Promt("Put b1");
double b2 = Promt("Put b2");

double x = (b2 - b1) / (-k2+k1);
double y = (b2*k1 - b1*k2) / (- k2 + k1);

System.Console.WriteLine($"[{x},{y}]");