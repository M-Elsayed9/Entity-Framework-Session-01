using Demo.Context;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            G03DbContext context = new G03DbContext();
            var result = context.Employees.Where(e => e.Equals("Mohamed")).FirstOrDefault();

        }
    }
}
