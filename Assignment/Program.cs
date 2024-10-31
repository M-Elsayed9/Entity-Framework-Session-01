using Assignment.Context;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext context = new ITIDbContext();
            context.Database.EnsureCreated();

        }
    }
}
