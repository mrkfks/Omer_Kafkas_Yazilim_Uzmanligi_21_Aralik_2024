// Kullanıcıdan veri alma

using System.ComponentModel;

Console.WriteLine("Name:");
string name = Console.ReadLine();

Console.WriteLine("Surname:");
string surname  = Console.ReadLine();

string nameSurname = name + " " +  surname;
Console.WriteLine(nameSurname);

// ******************************************************************************

//Type casting - Tür Dönüşümü
Console.WriteLine("Age:");
string stAge  = Console.ReadLine();
int age = Convert.ToInt32(stAge);
Console.WriteLine(age);

// ******************************************************************************

double n1 = 50.6;
double n2 = 70.6;
double dSum = n1 + n2; //121.2
int cdSum = Convert.ToInt32(dSum); //121

int cN1 = Convert.ToInt32(n1); //51
int cN2 = Convert.ToInt32(n2); //71
int sm = cN1 +  cN2;

Console.WriteLine("===================================================");
Console.WriteLine(cN1);
Console.WriteLine(cN2);
Console.WriteLine($"Toplam :{sm}"); //122

Console.WriteLine("===================================================");

// ****************************************************************************************************************************************************************
// Operatörler
// Aritmetik Operatörler
//+, -, *, /, %

double a = 50;
double b = 24;
double end = 0;

end = a + b;
Console.WriteLine($"Toplam: {end}");

end = a - b;
Console.WriteLine($"Çıkarma: {end}");

end = a / b;
Console.WriteLine($"Bölüm: {end}");

end = a * b;
Console.WriteLine($"Çarpım: {end}");

//Mod Alma (Bölümden Kalan)
end = b % 10;
Console.WriteLine($"Mod b %10: {end}");

//Arttırma ve Eksilme operatörleri (+1, -1, ++, --)

int X = 0 ;
X = X + 1;
Console.WriteLine($" X: {X}");

// ****************************************************************************

// Mantıksal Operörler (==, !=, <, >, <=, >=)

int q = 10;
int w = 11;

Console.WriteLine($"Değerlendirme yapılacak veriler {q} ve {w}");

bool status = false;

status = q == w;
Console.WriteLine($"== : {status}");

string username = "Ali";
status  = username.Equals( "Ali" );
Console.WriteLine($"== : {status} ");

Console.WriteLine("Lütfen Kullanıcı adınızı giriniz:");
username = Console.ReadLine();

Console.WriteLine("Lütfen Şifrenizi Giriniz:");
string pswrd = Console.ReadLine();

status = username.Equals("ali101");
Console.WriteLine($" username : {status} ");

status = pswrd.Equals ("12345");
Console.WriteLine($" Pasword: {status}");

// != "Eşit değil ise"

status = q != 0;
Console.WriteLine($" != : {status}");

// > "Sol tarafdaki değer sağ tarafdaki değerden büyük ise"

status = q > w;
Console.WriteLine($" > : {status}");

// < "Sol tarafdaki değer sağ taraftaki değerden büyük ise"
status = q < w;
Console.WriteLine($" < : {status}");


// >= "Sol taraftaki değer sağ tarafdaki değerden büyük veya eşit ise"
status = q >= w;
Console.WriteLine($" >= : {status}");


// <= "Sol tarafdaki değer sağ tarafdaki değerden küçük veya eşit ise"
status = q <= w;
Console.WriteLine($"<= : {status}");

//Logic Kalıplar "&&,||"

//"&& ->" Sol Tarafdaki şart ile sağ tarafdaki şart sağlanmış ise (True)

int ageX = 21;
status = ageX >= 18 && ageX <= 50;
Console.WriteLine($" && : {status}");

//"|| ->" Sol tarafdaki şart veya sağ tarafdaki şart sağlanmış ise (True)

status = q > 9 || q < 8;
Console.WriteLine($"|| : {status}");