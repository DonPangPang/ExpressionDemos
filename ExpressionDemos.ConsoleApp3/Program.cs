using System.Linq;
using System.Linq.Expressions;
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
var fixedQuery = companyNames.OrderBy(x => x);

#region Program1
// var length = 1;
// var query = companyNamesSource.Select(x=>x.Substring(0, length))
//     .Distinct();//去重

// length = 2;
// Console.WriteLine(string.Join(", ", query));
#endregion Program1

#region Program2
// bool sortByLength = true;

// var query = companyNamesSource;

// if(sortByLength)
// {
//     query = query.OrderBy(x=>x.Length);
// }
// else
// {
//     query = query.OrderByDescending(x=>x.Length);
// }
// Console.Write(string.Join(", ", query.ToList()));
#endregion Program2

#region Program3

string? startsWith = "W";
string? endsWith = "y";

Expression<Func<string, bool>> expr = (startsWith, endsWith) switch
{
    ("" or null, "" or null) => x => true,
    (_, "" or null) => x => x.StartsWith(startsWith),
    ("" or null, _) => x => x.EndsWith(endsWith),
    (_, _) => x => x.StartsWith(startsWith) || x.EndsWith(endsWith)
};

#endregion Program3
