using System;
namespace SOLID._4_i;

public class Insulin: Injectable
{
    public void AdministerInjection()
    {
        Console.WriteLine("Administer Insulin through injection");
    }
}