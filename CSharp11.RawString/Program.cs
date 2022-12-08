
var message1 = "This is a \"quoted text\" \n and I go to the new line";
Console.WriteLine(message1);

System.Console.WriteLine("_________________________");

var message = """
 This is a "quoted text" 
 and I go to the new line
 """;

Console.WriteLine(message);

System.Console.WriteLine("_________________________");

var message2 = """
{
    "name": "hamed"
}
""";

Console.WriteLine(message2);

Console.WriteLine("_________________________");

var Latitude = 2;
var Longitude = 2;
var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
""";
Console.WriteLine(location);


Console.WriteLine("_________________________");

var message3 = 
    @"
    select *
    from users
    where id=1
    ";

Console.WriteLine(message3);

var message4 = 
    """
    select *
    from users
    where id=1
    """;

Console.WriteLine(message4);