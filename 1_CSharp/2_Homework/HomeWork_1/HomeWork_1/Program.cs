//Homework-1


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

int difference = dateyear_int - birtYear_int;

bool status = birtYear_int == difference;
Console.WriteLine(status);


/*2. Kullanıcıdan bir sayı alarak, bu sayının çift mi tek mi olduğunu kontrol eden ve 
sonucu ekrana yazdıran bir program yazın.*/

Console.WriteLine("Çift veya tek olup olmadığını teyitlemek istediğin bir sayı giriniz:");
string number = Console.ReadLine();
int number_int = Convert.ToInt32(number);

int number_mod = number_int % 2;
bool numberBool = number_mod == 0;
Console.WriteLine(numberBool);



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

status = false;
status = number2int == 0;
Console.WriteLine("Bölen sayı sıfır olamaz!!");

status = number2int != 0;
int bolen = (number1int / number2int);
Console.WriteLine($"Sayıların bölümü: {bolen}");



/*4. Kullanıcıdan br ondalık sayı alarak, bu sayıyı tam sayıya dönüştürüp, 
dönüştürülmüş değer ve orjnal değer ekrana yazdıran br program yazın.*/


/*5. Kullanıcıdan br sayı alarak, bu sayının karesn ve küpünü hesaplayan ve 
sonuçları ekrana yazdıran br program yazın.*/


/*6. Kullanıcıdan br metn alarak, bu metn büyük harfe çevren ve ekrana yazdıran br 
program yazın.*/



/*7. Kullanıcıdan k sayı alarak, bu sayıların büyüklük karşılaştırmasını yapan ve 
büyük olan sayıyı ekrana yazdıran br program yazın. Sayılar eştse, eşt olduklarını 
belrten br mesaj yazdırın.*/



/*8. Kullanıcıdan br sayı alarak, bu sayının poztf m negatf m olduğunu kontrol eden 
ve sonucu ekrana yazdıran br program yazın.*/
