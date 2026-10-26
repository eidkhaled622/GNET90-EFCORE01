using EFTask1;

var context = new AppDbContext();

var data = context.Books.Select(x => x);

foreach (var b in data)
{
    Console.WriteLine($"Title: {b.Title}");
    Console.WriteLine($"ID: {b.ID}");
    Console.WriteLine($"ISBN: {b.ISBN}");
    Console.WriteLine($"Year: {b.publishYear}");
    Console.WriteLine($"Published: {b.published}");
}
