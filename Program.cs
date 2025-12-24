// dizi metotları (Array Methods)


string[] sehirler = {"zonguldak","rize","kocaeli"};
int[] plakalar = {67,53,41};

// sehirler[0] = "sakarya";
//sehirler.SetValue("sakarya",1);

Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler,"amasya"));

Array.Sort(sehirler);    //alfabetik şekilde sıralar 
Array.Sort(plakalar);    // küçükten büyüğe sıralar

Array.Reverse(plakalar);    //diziyi ters çevirir.

Array.Clear(sehirler);
Array.Clear(plakalar,0,1);

Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2));


