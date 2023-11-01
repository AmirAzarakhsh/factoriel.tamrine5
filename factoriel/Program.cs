int n, i;
long fact = 1;
Console.WriteLine("yek adad baraye factoril vared konid");
n = int.Parse(Console.ReadLine());
for (i = n; i >= 1; i--)
{
    fact *= i;
}
Console.WriteLine("factoril= " + fact);
Console.ReadKey();

// AMIRHOSSEIN AZARAKHSH .tamrine 5//