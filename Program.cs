using Dapper.Contrib.Extensions;
using Mercado.Models;
using Mercado.Repositories;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Mercado;User ID= sa;Password=1q2w3e4r@#$;Trust Server Certificate=true";
    private static void Main(string[] args)
    {
        var Repository = new CategoryRepository(CONNECTION_STRING);
        var Category = Repository.CreateCategory("Legume");
        Console.WriteLine();
    }

}



