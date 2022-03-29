using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var companyNames = new[] {
    "Consolidated Messenger", "Alpine Ski House", "Southridge Video",
    "City Power & Light", "Coho Winery", "Wide World Importers",
    "Graphic Design Institute", "Adventure Works", "Humongous Insurance",
    "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
    "Blue Yonder Airlines", "Trey Research", "The Phone Company",
    "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee"
};

IQueryable<string> companyNamesSource = companyNames.AsQueryable();
var fixedQuery = companyNames.OrderBy(x=>x);

var length = 1;
var query = companyNamesSource.Select(x=>x.Substring(0, length))
    .Distinct();

length = 2;
Console.WriteLine(string.Join(", ", query));
