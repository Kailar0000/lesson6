double Length(int[] x ,int[] y )
{
    double xy =0;
    xy = Math.Round(Math.Sqrt(Math.Pow( y[1]-x[1], 2 )+Math.Pow( y[2]-x[2], 2 )));
    return xy;
}
Console.Clear();
Console.WriteLine("Вводите числа через пробел:");
int[] a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Вводите числа через пробел:");
int[] b = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Вводите числа через пробел:");
int[] c = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double ab=Length(a, b);
double bc=Length(b, c);
double ac=Length(a, c);
double p=(ab+bc+ac)/2;
double S=Math.Round(Math.Sqrt(p(p-a)(p-b)(p-c)));
Console.WriteLine(S);