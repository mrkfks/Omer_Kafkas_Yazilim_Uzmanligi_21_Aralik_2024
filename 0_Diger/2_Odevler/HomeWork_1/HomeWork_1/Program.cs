//Homework-1

//  ********************************************************************************************************************

/*1. Kullanıcıdan adını, yaşını ve doğum yılını alarak, kullanıcının yaşını kontrol eden 
ve doğru olup olmadığını ekrana yazdıran bir program yazın.*/

Console.WriteLine("Adınız:");
string name = Console.ReadLine();

Console.WriteLine("Yaşınız:");
string older = Console.ReadLine();
int older_int = Convert.ToInt32(older);

Console.WriteLine("Doğum Yılınız:");
string birtYear = Console.ReadLine();
int birtYear_int = Convert.ToInt32(birtYear);

Console.WriteLine("Mevcut yıl:");
string dateYear = Console.ReadLine();
int dateyear_int = Convert.ToInt32(dateYear);

if (older_int == dateyear_int - birtYear_int) { Console.WriteLine("Yaşınız doğru hesaplanmıştır."); }
else { Console.WriteLine("Yaşınız yanlış hesaplanmıştır.");}

//  ********************************************************************************************************************

/*2. Kullanıcıdan bir sayı alarak, bu sayının çift mi tek mi olduğunu kontrol eden ve 
sonucu ekrana yazdıran bir program yazın.*/

Console.WriteLine("Çift veya tek olup olmadığını teyitlemek istediğin bir sayı giriniz:");
string number = Console.ReadLine();
int number_int = Convert.ToInt32(number);
if (number_int % 2 == 0) { Console.WriteLine("Girilen sayı çifttir."); }
else { Console.WriteLine("Girilen sayı tektir."); }

//  ********************************************************************************************************************

/*3. Kullanıcıdan iki sayı alarak, bu sayıların toplamını, farkını, çarpımını ve bölümünü 
hesaplayan ve sonuçları ekrana yazdıran bir program yazın. Bölme işleminde, 
bölenin sıfır olup olmadığını kontrol edin ve sıfırsa hata mesajı verin.*/

Console.WriteLine("Birinci sayıyı giriniz:");

string number1 = Console.ReadLine();
int number1int = Convert.ToInt32(number1);

Console.WriteLine("İkinci sayıyı giriniz:");
string number2 = Console.ReadLine();
int number2int = Convert.ToInt32(number2);

int toplam = (number1int + number2int);
Console.WriteLine($"sayıların Toplamı: {toplam}");

int fark = (number1int - number2int);
Console.WriteLine($"Sayıların farkı: {fark}");

int carpim = (number1int * number2int);
Console.WriteLine($"Sayıların Çarpımı: {carpim}");

if (number2int == 0) { Console.WriteLine("Bölen sayı sıfır olamaz!!"); }
else { int bolen = (number1int / number2int); Console.WriteLine($"Sayıların bölümü: {bolen}");}

//  ********************************************************************************************************************

/*4. Kullanıcıdan br ondalık sayı alarak, bu sayıyı tam sayıya dönüştürüp, 
dönüştürülmüş değer ve orjnal değer ekrana yazdıran br program yazın.*/

Console.WriteLine("Bir ondalıklı sayı yazınız:");
string sayı = Console.ReadLine();
double sayıDouble = Convert.ToDouble(sayı);
Console.WriteLine(sayıDouble);
int sayıİnt = Convert.ToInt32(sayı);
Console.WriteLine(sayıİnt);

//  ********************************************************************************************************************

/*5. Kullanıcıdan bir sayı alarak, bu sayının karesn ve küpünü hesaplayan ve 
sonuçları ekrana yazdıran br program yazın.*/

Console.WriteLine("Bir sayı giriniz:");
string sayi = Console.ReadLine();
int sayiInt = Convert.ToInt32(sayi);
int karesi = sayiInt * sayiInt;
Console.WriteLine($"Karesi {karesi}");
int kupu = karesi * sayiInt;
Console.WriteLine($"Küpü: {kupu}");

//  ********************************************************************************************************************

/*6. Kullanıcıdan br metin alarak, bu metn büyük harfe çevren ve ekrana yazdıran bir 
program yazın.*/

Console.WriteLine("Büyük Harfe Çevrilecek Bir Metin Girişi Yapınız:");
string metin = Console.ReadLine();

Console.WriteLine("Metnin Büyük hale Çevrilmiş Hali:");
string metinUpper = metin.ToUpperInvariant ();


Console.WriteLine("Büyük Harfe Çevrilecek Bir Metin Girişi Yapınız:");
metin = Console.ReadLine();

Console.WriteLine("Metnin Büyük hale Çevrilmiş Hali:");
metinUpper = metin.ToUpperInvariant();
Console.WriteLine(metinUpper);

//  ********************************************************************************************************************

/*7. Kullanıcıdan iki sayı alarak, bu sayıların büyüklük karşılaştırmasını yapan ve 
büyük olan sayıyı ekrana yazdıran bir program yazın. Sayılar eşitse, eşit olduklarını 
belirten bir mesaj yazdırın.*/

Console.WriteLine("Birinci sayıyı giriniz:");
string sayi1 = Console.ReadLine();
int sayi1Int = Convert.ToInt32(sayi1);

Console.WriteLine("İkinci sayıyı giriniz:");
string sayi2 = Console.ReadLine();
int sayiInt2 = Convert.ToInt32(sayi2);

if (sayi1Int > sayiInt2) {Console.WriteLine("Birinci sayı ikinci sayıdan büyüktür.");}

else if (sayi1Int < sayiInt2) { Console.WriteLine("İkinci sayı birinci sayıdan büyüktür."); }

else { Console.WriteLine("İki sayı da birbirine eşittir."); }

//  ********************************************************************************************************************

/*8. Kullanıcıdan bir sayı alarak, bu sayının pozitif mi negatif mi olduğunu kontrol eden 
ve sonucu ekrana yazdıran bir program yazın.*/

Console.WriteLine("Kontrolü yapılacak sayıyı giriniz:");
if (sayiInt > 0) { Console.WriteLine("Sayı pozitiftir."); }
else if (sayiInt < 0) { Console.WriteLine("Sayı negatiftir."); }
else { Console.WriteLine("Sayı sıfırdır."); }

//  ********************************************************************************************************************