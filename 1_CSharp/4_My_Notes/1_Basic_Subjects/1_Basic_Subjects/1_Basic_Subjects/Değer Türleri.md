<h1>Değer Türleri (Value Types)</h1>
<p>C# dilinde veri türleri (data types), verilerin 
nasıl saklanacağı ve işleneceği hakkında bilgi sağlar. 
C# veri türleri iki ana kategoriye ayrılır: değer türleri 
value types) ve referans türleri (reference types). İşte temel 
veri türleri:</p>
<ul> <h3>Değer Türleri</h3>
<p>Değer türleri, değişkenlerin doğrudan veriyi sakladığı türlerdir. 
Bellekte yığın (stack) alanında saklanırlar.</p>
<b><li>Tamsayı Türleri (Integral Types):</li></b>
<p>

<b>byte:</b> 8-bit, 0 - 255 arası tam sayı

<b>sbyte:</b> 8-bit, -128 - 127 arası tam sayı

<b>short:</b> 16-bit, -32,768 - 32,767 arası tam sayı

<b>ushort:</b> 16-bit, 0 - 65,535 arası tam sayı

<b>int:</b> 32-bit, -2,147,483,648 - 2,147,483,647 arası tam sayı

<b>uint:</b> 32-bit, 0 - 4,294,967,295 arası tam sayı

<b>long:</b> 64-bit, -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807 arası tam sayı

<b>ulong:</b> 64-bit, 0 - 18,446,744,073,709,551,615 arası tam sayı

</p>
<b><li>Kesirli Sayı Türleri (Floating-point Types):</li></b>
<p>

<b>float:</b> 32-bit tek hassasiyetli kesirli sayı

<b>double:</b> 64-bit çift hassasiyetli kesirli sayı

<b>decimal:</b> 128-bit yüksek hassasiyetli kesirli sayı (genellikle finansal ve parasal hesaplamalar için kullanılır)

</p>

<b><li>Mantıksal Tür (Logical Type):</li></b>
<p><b>bool:</b> true veya false değerlerini saklar</p>
<b><li>Karakter Türü (Character Type):</li></b>
<p><b>char:</b> 16-bit Unicode karakter</p>
<b><li>Yapılar (Structs):</li></b>
<p>Kullanıcı tarafından tanımlanan değer türleridir.</p>
<b><li>Enum (Numaralandırma):</li></b>
<p>Sabit değerler kümesini temsil eder.</p>
</ul>
<ul> <h3>Referans Türleri</h3>
<p>Referans türleri, değişkenlerin verinin bellekteki 
adresini sakladığı türlerdir. Bellekte yığın (stack) 
yerine yığın (heap) alanında saklanırlar.</p>
<b><li>Sınıflar (Classes):</li></b>
<p>Sınıflar, nesnelerin (objeler) özelliklerini ve davranışlarını tanımlamak için kullanılır. Sınıf, veri (özellikler) ve bu veri üzerinde işlem yapacak metotları (davranışlar) bir araya getiren bir şablondur. Sınıflar, benzer türdeki nesnelerin yaratılmasını sağlar ve kodun daha 
modüler ve yeniden kullanılabilir olmasını destekler.</p>
<b><li>Nesne Türü (Object Type):</li></b>
<p>Tüm veri türlerinin temel sınıfıdır.</p>
<b><li>Dizi Türü (Array Type):</li></b>
<p>Aynı türden elemanların bir koleksiyonunu saklar.</p>
<b><li>Dize Türü (String Type):</li></b>
<p>Karakterlerin bir dizisini saklar.</p>
<b><li>Arabirimler (Interfaces):</li></b>
<p>Yalnızca üyelerin imzalarını içerir, herhangi bir uygulama içermez.</p>
<b><li>Temsilciler (Delegates):</li></b>
<p>Metotların temsilcileridir ve geriye dönüş türü ile parametre listesi aynı olan metotları çağırabilir.</p>
</ul>