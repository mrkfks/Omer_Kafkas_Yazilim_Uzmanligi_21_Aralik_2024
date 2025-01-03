// HomeWork_2


/********************************************************************************************************************/
//1.Soru: Bir öğrencinin adını, yaşını ve not ortalamasını tutan değişkenler tanımlayın ve bu bilgileri ekrana yazdırın.
//Cevap:

Console.WriteLine("Öğrenci Adı: ");
string ad = Console.ReadLine();

Console.WriteLine("Öğrenci Yaşı: ");
string yas1 = Console.ReadLine();
int yasInt1 = Convert.ToInt32(yas1);

Console.WriteLine("Öğrenci Not Ortalaması: ");
string notOrtalamasi = Console.ReadLine();

Console.WriteLine("Öğrenci Adı: " + ad);
Console.WriteLine("Öğrenci Yaşı: " + yas1);
Console.WriteLine("Öğrenci Not Ortalaması: " + notOrtalamasi);


/********************************************************************************************************************/
//2. Soru: Bir dikdörtgenin uzunluğunu ve genişliğini kullanıcıdan alarak alanını hesaplayan bir program yazın.
//Cevap:

Console.WriteLine("Dikdörtgenin Uzunluğu: ");
string uzunluk = Console.ReadLine();
int uzunlukInt = Convert.ToInt32(uzunluk);

Console.WriteLine("Dikdörtgenin Genişliği: ");
string genislik = Console.ReadLine();
int genislikInt = Convert.ToInt32(genislik);

int alan = uzunlukInt * genislikInt;
Console.WriteLine("Dikdörtgenin Alanı: " + alan);


/********************************************************************************************************************/
//3. Soru: Kullanıcıdan alınan bir string değer integer'a çevirip, bu değer 10 ile çarpan ve sonucu ekrana yazdıran bir program yazın.
//Cevap:

Console.WriteLine("Bir sayı giriniz:");
string sayi = Console.ReadLine();
int sayiInt = Convert.ToInt32(sayi);
int sonuc = sayiInt * 10;
Console.WriteLine("Girilen sayının 10 ile çarpımı: " + sonuc);


/********************************************************************************************************************/
//4. Soru: Kullanıcıdan alınan bir double değeri integer'a çevirip, bu değer ekrana yazdıran bir program yazın.
//Cevap:

Console.WriteLine("Bir ondalıklı sayı giriniz:");
string sayi4 = Console.ReadLine();
double sayi4double = Convert.ToDouble(sayi4);
double asagiYuvarlanmisSayi = Math.Floor(sayi4double);
Console.WriteLine("Girilen sayının tam kısmı: " + asagiYuvarlanmisSayi);


/********************************************************************************************************************/
//5. Soru: Kullanıcıdan adını ve doğum yılını alarak, kullanıcının yaşını hesaplayan ve ekrana yazdıran bir program yazın.
//Cevap:

Console.WriteLine("Adınız: ");
ad = Console.ReadLine();

Console.WriteLine("Mevcut yıl: ");
string yil5 = Console.ReadLine();
int yil5Int = Convert.ToInt32(yil5);

Console.WriteLine("Doğum yılınız: ");
string dogumYili5 = Console.ReadLine();
int dogumYili5Int = Convert.ToInt32(dogumYili5);

int yas5 = yil5Int - dogumYili5Int;
Console.WriteLine("Yaşınız: " + yas5);

/********************************************************************************************************************/
//6. Soru: Kullanıcıdan iki sayı alarak bu sayıların toplamını, farkını, çarpımını ve bölümünü hesaplayan bir program yazın.
//Cevap:

Console.WriteLine("Birinci sayıyı giriniz:");
string sayi1 = Console.ReadLine();
int sayiInt1 = Convert.ToInt32(sayi1);

Console.WriteLine("İkinci sayıyı giriniz:");
string sayi2 = Console.ReadLine();
int sayiInt2 = Convert.ToInt32(sayi2);

int toplam = sayiInt1 + sayiInt2;
int fark = sayiInt1 - sayiInt2;
int carpim = sayiInt1 * sayiInt2;
int bolum = sayiInt1 / sayiInt2;

Console.WriteLine("Toplam: " + toplam);
Console.WriteLine("Fark: " + fark);
Console.WriteLine("Çarpım: " + carpim);
Console.WriteLine("Bölüm: " + bolum);

/********************************************************************************************************************/
//7. Soru: Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olup olmadığını kontrol eden bir program yazın.
//Cevap:

Console.WriteLine ("Denetimi yapılacak bir sayı giriniz:");
string sayi7 = Console.ReadLine();
int sayiInt7 = Convert.ToInt32(sayi7);

if (sayiInt7 < 0)
    Console.WriteLine("Sayı Negatiftir.");
else if (sayiInt7 > 0)
    Console.WriteLine("Sayı Pozitiftir.");
else
    Console.WriteLine("Sayı Sıfırdır.");


/********************************************************************************************************************/
//8. Soru: Kullanıcıdan alınan bir not değerine göre, notun "Geçti" veya "Kaldı" şeklinde olup olmadığını belirleyen bir program yazın.
//Cevap:

Console.WriteLine("Notunuzu giriniz:");
string not8 = Console.ReadLine();
int notInt8 = Convert.ToInt32(not8);
if (notInt8 <= 100 && notInt8 >= 50)
    Console.WriteLine("Geçti");
else
    Console.WriteLine("Kaldı");


/********************************************************************************************************************/
//9. Soru: 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın.
//Cevap:

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
};

/********************************************************************************************************************/
//10. Soru: Kullanıcıdan alınan bir sayının faktöriyelin hesaplayan bir program yazın.
//Cevap:

Console.WriteLine("Faktöriyeli hesaplanacak sayıyı giriniz:");
string sayi10 = Console.ReadLine();
int sayi10Int = Convert.ToInt32(sayi10);

int factoriel = 1;
for (int i = 1; i <= sayi10Int; i++)
{ 
factoriel = factoriel * i; 
}
Console.WriteLine("Faktöriyel: " + factoriel);


/********************************************************************************************************************/
//11. Soru: Kullanıcıdan alınan iki sayının her ikisinin de pozitif olup olmadığını kontrol eden bir program yazın.
//Cevap:

Console.WriteLine("İlk sayıyı giriniz:");
string sayi111 = Console.ReadLine();
int sayiInt111 = Convert.ToInt32(sayi111);

Console.WriteLine("İkinci sayıyı giriniz:");
string sayi112 = Console.ReadLine();
int sayiInt112 = Convert.ToInt32(sayi112);

if (sayiInt111 >0 && sayiInt112 > 0)
    Console.WriteLine("Her iki sayı da pozitiftir.");
else
    Console.WriteLine("Her iki sayı da pozitif değildir.");


/********************************************************************************************************************/
//12. Soru: Kullanıcıdan alınan bir sayının 10 ile 20 arasında olup olmadığını kontrol eden bir program yazın.
//Cevap:

Console.WriteLine("Bir sayı giriniz:");
string sayi12 = Console.ReadLine();
int sayiInt12 = Convert.ToInt32(sayi12);

if (sayiInt12 >=10 && sayiInt12 <= 20)
    Console.WriteLine("Sayı 10 ile 20 arasındadır.");
else
    Console.WriteLine("Sayı 10 ile 20 arasında değildir.");


/********************************************************************************************************************/



