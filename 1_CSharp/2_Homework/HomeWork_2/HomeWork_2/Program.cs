// HomeWork_2


/********************************************************************************************************************/
//1.Soru: Bir öğrencinin adını, yaşını ve not ortalamasını tutan değişkenler tanımlayın ve bu bilgileri ekrana yazdırın.
//Cevap:

console.writeline("Öğrenci Adı: ");
string ad = Console.ReadLine();

console.writeline("Öğrenci Yaşı: ");
string yas = Console.ReadLine();

console.writeline("Öğrenci Not Ortalaması: ");
string notOrtalamasi = Console.readLine();

console.writeline("Öğrenci Adı: " + ad);

console.writeline("Öğrenci Yaşı: " + yas);

console.writeline("Öğrenci Not Ortalaması: " + notOrtalamasi);


/********************************************************************************************************************/
//2. Soru: Bir dikdörtgenin uzunluğunu ve genişliğini kullanıcıdan alarak alanını hesaplayan bir program yazın.
//Cevap:

Console.writeLine("Dikdörtgenin Uzunluğu: ");
string uzunluk = console.readline
int uzunlukInt = Convert.ToInt32(uzunluk);

console.writeline("Dikdörtgenin Genişliği: ");
string genislik = console.readline
int genislikInt = convert.toint32(genislik);

int alan = uzunlukInt * genislikInt;
console.writeline ("Dikdörtgenin Alanı:" + alan);


/********************************************************************************************************************/
//3. Soru: Kullanıcıdan alınan bir string değer integer'a çevirip, bu değer 10 ile çarpan ve sonucu ekrana yazdıran bir program yazın.
//Cevap:

console.writeline("Bir sayı giriniz:");
string sayi = console.readline();
int sayıInt = convert.toInt32(sayi);
sonuc = sayıInt * 10;
console.writeline("Girilen sayının 10 ile çarpımı: " + sonuc);


/********************************************************************************************************************/
//4. Soru: Kullanıcıdan alınan bir double değeri integer'a çevirip, bu değer ekrana yazdıran bir program yazın.
//Cevap:

console.writeline("Bir ondalıklı sayı giriniz:");
string sayi = console.readline();
double sayıDouble = convert.toDouble(sayi);
int sayıInt = convert.toInt32(sayıDouble);
console.writeline("Girilen sayınının tam kısmı: " + sayıInt);


/********************************************************************************************************************/
//5. Soru: Kullanıcıdan adını ve doğum yılını alarak, kullanıcının yaşını hesaplayan ve ekrana yazdıran bir program yazın.
//Cevap:

Console.writeLine("Adınız: ");
string ad =console.readline();

Console.witeline ("Mevcut yıl: ");
string yil = console.readline();
int yilint = convert.toInt32(yil);

console.writeline("Doğum yılınız: ");
string dogumyili =console.readline();
int dogumyiliint = convert.toInt32(dogumyili);

int yas = yilint - dogumyiliint;
console.writeline("Yaşınız: " + yas);

/********************************************************************************************************************/
//6. Soru: Kullanıcıdan iki sayı alarak bu sayıların toplamını, farkını, çarpımını ve bölümünü hesaplayan bir program yazın.
//Cevap:

console.writeline("Birinci sayıyı giriniz:");
string sayi1 =console.readline();
int saiyint1 = convert.toInt32(sayi1);

console.writeline("İkinci sayıyı giriniz:");
string sayi2 = console.readline();
int sayiint2 =convert.toInt32(sayi2);

int toplam = sayiint1 + sayiint2;
int fark = sayiint1 - sayiint2;
int carpim = sayiint1 * sayiint2;
int bolum = sayiint1 / sayiint2;

console.writeline("Toplam: " + toplam);
console.writeline("Fark: " + fark);
console.writeline("Çarpım: " + carpim);
console.writeline("Bölüm: " + bolum);

/********************************************************************************************************************/
//7. Soru: Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olup olmadığını kontrol eden bir program yazın.
//Cevap:









/********************************************************************************************************************/
//8. Soru: Kullanıcıdan alınan bir not değerine göre, notun "Geçti" veya "Kaldı" şeklinde olup olmadığını belirleyen bir program yazın.
//Cevap:








/********************************************************************************************************************/
//9. Soru: 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın.
//Cevap:








/********************************************************************************************************************/
//10. Soru: Kullanıcıdan alınan bir sayının faktöriyelin hesaplayan bir program yazın.
//Cevap:








/********************************************************************************************************************/
//11. Soru: Kullanıcıdan alınan k sayının her ikisinin de pozitif olup olmadığını kontrol eden bir program yazın.
//Cevap:







/********************************************************************************************************************/
//12. Soru: Kullanıcıdan alınan bir sayının 10 ile 20 arasında olup olmadığını kontrol eden bir program yazın.
//Cevap:






/********************************************************************************************************************/



