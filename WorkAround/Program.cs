//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Nigar";
    string soyad = "Aliyeva";
    int dogumYili = 2003;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
}

Vatandas vatandas1 = new();

//SalamVer(isim: "Nigar");
//static void SalamVer(string isim="noname")
//{
//    Console.WriteLine("salam" + isim);
//}

//int sonuc = Topla(6, 50);
//static int Topla(int sayi1=5, int sayi2 = 10)
//{
//    int sonuc = sayi1 + sayi2;
//    Console.WriteLine("Toplam : " + sonuc.ToString());
//    return sonuc;
//}
Person person1 = new Person();
person1.FirstName = "Nigar";
person1.LastName = "Aliyeva";
person1.DateOfBirthYear = 2003;
person1.NationalIdentity = 122;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}
//List<string> yeniSehirler = new List<string>{ "Ankara", "Baku" };
