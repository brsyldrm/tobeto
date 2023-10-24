string city = "Ankara";
Console.WriteLine(city[0]);

foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "İstanbul";
string result = city + city2;

Console.WriteLine(result);
Console.WriteLine(String.Format("{0} {1}",city,city2));




string sentence = "My name is Barış Yıldırım";
var result2 = sentence.Length;
var result3 = sentence.Clone();
sentence = "My name is Ramazan Yıldırım";

bool result4 = sentence.EndsWith("ğ"); //ğ ile bitiyor mu kontrolü
bool result5 = sentence.StartsWith("My name");

var result6 = sentence.IndexOf("name");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2, 5);

Console.WriteLine(result2);