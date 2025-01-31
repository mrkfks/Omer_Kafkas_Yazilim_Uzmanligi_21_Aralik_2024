//tek satırlı açıklama satırı

/*çok
satırlı
açıklama
birimi*/

int a = 10;
int b = 40;

int sum = a + b;

Console.WriteLine(sum);

//String değişken türü
//Karakter Katarı

string name = "Ali";
string surname = "DESİDERO";
string sparator = "-";

string nameSurname = name + sparator + surname;
Console.WriteLine(nameSurname);

string city = "İstanbul";
string area = "Marmara";
string cityArea = city + sparator + area;
Console.WriteLine(cityArea);

string stNumber1 = "100";
string stNumber2 = "50";
Console.WriteLine(stNumber1 + stNumber2);

//"int" tam sayı değişkenidir.
int num1 = 2147456445;
int num2 = 2147456445;
long sumNumber = num1 + num2;
Console.WriteLine(sumNumber);

//"byte" int veri türüne göre daha az yer kaplayan değişkendir.
byte b1 = 255;
byte b2 = 255;

int b3 = b1 + b2;

Console.WriteLine(b3);

//"short", "byte" ile "int" arasında değer alabilen veri büyüklüğüdür.

short sh1 = 32457;
short sh2 = 32456;

int sh3 = sh1 + sh2;

Console.WriteLine(sh3);

// "long", "int" değerlerinden çok daha büyük tam sayılar için vardır.

long long1 = 99999999999999999;
Console.WriteLine(long1);

//string ID ID genellikle bir veritabanı tablosunda
//bulunan bir kaydın benzersiz bir şekilde tanımlanmasını sağlayan bir değerdir.

string ID = "a01sd2x45d5gb5r2e0d4e5f7";

//Ondalıklı Değer Türleri
//"Double" büyük ondalıklı işlemler yapılmak istendiğinde kullanılmalıdır.

double double1 = 100;
double double2 = 67;
double double3 = double1 / double2;
Console.WriteLine(double3);

int n1 = 100;
int n2 = 67;
int n3 = n1 / n2;
Console.WriteLine(n3);

//"Float" küçük ondalıklı işlemler sırasında kullanılabilen ondalıklı değerler

float f1 = 12.4f;
float f2 = 45.7f;
float f3 = f1 / f2;
Console.WriteLine(f3);

//"Boolean" karar kontrol yapılarında kullanılan değişkendir. true-false değerler alılar. default olarak "false" kabul edilirler.

bool status1 = false;
bool status2 = false;
status1 = a>b;
status2 = a<b;
Console.WriteLine(status1);
Console.WriteLine(status2);

//"char" veri türü içerisine tek bir karakter alabilen değişken türüdür.
char c1 = 'A';
char c2 = 'L';
char c3 = 'İ';
string nameString = "Ali";
Console.WriteLine(nameString, c1, c2, c3);
