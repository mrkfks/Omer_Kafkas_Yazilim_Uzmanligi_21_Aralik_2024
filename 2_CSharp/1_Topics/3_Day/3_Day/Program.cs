//Karar Kontrol Yapısı
//if-else yapısı
// Kullanıcıdan yaşını girmesini istedinin ve yaşının 18'den büyük olup olmadığını kontrol edin. 18'den büyükse ekrana "Üye Olabilirsiniz" yazdırın. 18'den küçükse ekrana "Üye Olamazsınız."


Console.WriteLine("Yaşınızı giriniz: ");
String stAge = Console.ReadLine();

    int age = Convert.ToInt32(stAge);

if (age > 0)
{
    if (age >= 18)
    {
        Console.WriteLine("Üye Olabilirsiniz");
    }
    else
    {
        Console.WriteLine("Üye Olamazsınız");
    }
}
else
{
    Console.WriteLine("Yaşınızı yanlış girdiniz.");
}

string email = "ali@email.com";
string password = "12345";

//logic -> && (ve) || (veya)
if (email == "ali@email.com" && password == "12345")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
}

if (email.Equals("ali@email.com") && password.Equals("12345"))
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
}

//else if yapısı

// doğruyu bulduğunda diğerlerine bakmaz

Console.WriteLine("==================================");


Console.WriteLine("Adınız: ");
string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Adınızı giriniz");
}
else
{
    Console.WriteLine("Soyadınız: ");
    string surname = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(surname))
    {
        Console.WriteLine("Soyadınızı giriniz");
    }
    else
    {
        Console.WriteLine("Telefon Numaranız: ");
        string phone = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(phone))
        {
            Console.WriteLine("Telefon numaranızı giriniz");
        }
        else
        {
            Console.WriteLine("Kayıt Başarılı");
        }
    }
}


Console.WriteLine("==================================");
int dayNumber = 6;

if (dayNumber == 1) { Console.WriteLine("Gönderim Pazartrsi"); }
else if (dayNumber == 2) { Console.WriteLine("Gönderim Salı"); }
else if (dayNumber == 3) { Console.WriteLine("Gönderim Çarşamba"); }
else if (dayNumber == 4) { Console.WriteLine("Gönderim Perşembe"); }
else if (dayNumber == 5) { Console.WriteLine("Gönderim Cuma"); }
else if ( dayNumber == 6) { Console.WriteLine("Seçtiğiniz Gün Gönderimimiz bulunmamaktadır"); }
else if (dayNumber == 7) { Console.WriteLine("Seçtiğiniz Gün Gönderimimiz bulunmamaktadır"); }
else { Console.WriteLine("Hatalı Gün Numarası"); }



//switch-case yapısı
// if-else yapısının alternatifidir ve daha okunabilir bir yapıdır.
// switch-case yapısında sadece eşitlik durumları kontrol edilir. Diğer durumlar için if-else yapısı kullanılır.
// switch-case yapısında sadece sabit değerler kullanılabilir. Değişkenler kullanılamaz.

string menu = " ";
switch (menu)
{
    case "Haberler":
        Console.WriteLine("Haberler Tıklandı");
        break;,
    case "Videolar":
        Console.WriteLine("Videolar Tıklandı");
        break;
    default:
        Console.WriteLine("Tümü Seçildi");
        break;
}

Console.WriteLine("==================================");
// tek satırlı if-else yapısı
int number = 5;
string result = number > 5 ? "Sayı 5'ten büyük" : "Sayı 5'ten küçük veya eşit";
Console.WriteLine(result);

string gun = dayNumber == 2 ? "Salı" : "Çarşamba";
Console.WriteLine(gun);

Console.WriteLine("==================================");


//diziler
// bir değişken içerisinde birden fazla değeri saklamak için kullanılır.
// dizilerde elemanlar sıfırdan başlar.
// dizilerde eleman sayısını belirtmek zorunludur.
// dizilerde eleman sayısını belirtmezsek eleman sayısı 0 olur.


Console.WriteLine("İndex'i giriniz:");


string[] cities = { "İstanbul", "Ankara", "Bursa", "Adana", "Gaziantep" };

Console.WriteLine(cities);
int index = 4;

//Length -> dizinin eleman sayısını verir.

int size = cities.Length;
Console.WriteLine("Dizi size : " + size);

if (index > -1 && size > index)
{
    Console.WriteLine("Seçilen şehir: " + cities[index]);
}
else
{
    Console.WriteLine($"Lütfen 0-{size-1} arasında bir değer giriniz.");
}

//int dizi tanımlama
int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
Console.WriteLine(numbers[2]);

Console.WriteLine("==================================");

//loop yapısı -> döngüler -> for, while, do-while döngüleri vardır. 
//for döngüsü" -> belirli bir şart sağlandığı sürece döngüyü çalıştırır.
//for döngüsü içerisinde 3 adet parametre bulunur.
//1. parametre -> başlangıç değeri
//2. parametre -> bitiş değeri
//3. parametre -> artış değeri


    for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}

