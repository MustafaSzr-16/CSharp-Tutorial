// Array Slicing

string[] sehirler = {"zonguldak","rize","kocaeli","istanbul","ankara","çanakkale"};

foreach(var sehir in sehirler[2..])
{
    Console.WriteLine(sehir);
}    

string il = "kocaeli";

Console.WriteLine(il[..5]);