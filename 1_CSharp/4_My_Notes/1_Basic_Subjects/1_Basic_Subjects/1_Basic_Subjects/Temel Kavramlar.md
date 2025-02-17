<h1>Namespace</h1>
<p>Namespace (ad alanı) fonksiyonu, sınıflar, arayüzler, 
fonksiyonlar ve diğer tür tanımlayıcıların adlarını düzenlemek ve çakışmalarını önlemek için kullanılır. 
Namespace'ler, kodun daha okunabilir ve yönetilebilir olmasını sağlar ve büyük projelerdeki kod bölümlerinin 
mantıksal olarak gruplandırılmasına yardımcı olur.</p>

<h1>Using Anahtar Kelimesi</h1>
<p>C# dilinde using anahtar kelimesi, birkaç farklı amaç için kullanılır ve programın çeşitli bölümlerinde 
önemli roller oynar. Bu rollerden bazıları şunlardır:</p>
<ul>
	<b><li>Namespace İthal Etme</li></b>
	<p>Belirli bir namespace'i (ad alanı) programınıza ithal etmek için kullanılır. 
	Bu sayede, belirli ad alanındaki sınıfları ve diğer üyeleri kısaltarak kullanabilirsiniz.</p>
	
	<b><li>Kaynak Yönetimi</li></b>
	<p>IDisposable arayüzünü uygulayan nesnelerin ömrünü yönetmek için kullanılır. 
	Bu tür nesneler, belirli kaynakları (dosyalar, veritabanı bağlantıları vb.) kullanır ve bu kaynakları 
	serbest bırakmak önemlidir. using ifadesi, bu nesnelerin işlerini bitirdikten sonra otomatik olarak serbest 
	bırakılmasını sağlar.</p>
	<b><li>Statik Üyelerin İthal Edilmesi</li></b>
	<p>using static ifadesi, belirli bir sınıfın statik üyelerini (metotlar, sabitler vb.) ithal etmek için kullanılır. 
	Bu sayede, bu üyeler doğrudan kullanılabilir.</p>
</ul>

<h1>Erişim Belirteçleri</h1>
<ul>
	<b><li>public</li></b>
	<p>Bir üyenin public olarak tanımlanması, bu üyenin programın her yerinden erişilebilir olmasını sağlar. Erişim kısıtlaması yoktur.</p>
	<b><li>private</li></b>
	<p>Bir üyenin private olarak tanımlanması, bu üyenin yalnızca tanımlandığı sınıfın içinden erişilebilir olmasını sağlar. 
	Bu, varsayılan erişim belirleyicisidir.</p>
	<b><li>protected</li></b>
	<p>Bir üyenin protected olarak tanımlanması, bu üyenin tanımlandığı sınıfın içinden ve bu sınıftan türetilmiş (inherit) alt sınıflar tarafından erişilebilir
	olmasını sağlar.</p>
	<b><li>internal</li></b>
	<p>Bir üyenin internal olarak tanımlanması, bu üyenin yalnızca aynı derleme (assembly) içinde erişilebilir olmasını sağlar. Yani, 
	farklı projelerden bu üyeye erişim sağlanamaz.</p>
	<b><li>protected internal</li></b>
	<p>Bir üyenin protected internal olarak tanımlanması, bu üyenin aynı derleme içinde ya da farklı bir derlemede türetilmiş alt 
	sınıflar tarafından erişilebilir olmasını sağlar.</p>
	<b><li>private protected</li></b>
	<p>Bir üyenin private protected olarak tanımlanması, bu üyenin aynı derleme içinde ve sadece türetilmiş alt sınıflar tarafından 
	erişilebilir olmasını sağlar.</p>

<h1>Statik Anahtar Kelimesi</h1>
<p>C# dilinde static anahtar kelimesi, sınıflar, metotlar, değişkenler ve
özellikler için kullanılır ve bu elemanların sınıfın bir örneği (instance) 
oluşturulmadan erişilebilir olmasını sağlar. static olarak tanımlanan elemanlar, 
sınıfın tüm örnekleri arasında paylaşılır ve sınıfın kendisine ait olur. 
Bu, bellek yönetimini ve kodun daha etkili kullanılmasını sağlar.</p>

<h2>Anahtar Kelimesinin Kullanım Alanları</h2>
<ul>
	<b><li>Statik Metotlar</li></b>
	<p>Statik metotlar, sınıfın bir örneği oluşturulmadan doğrudan sınıf adı üzerinden çağrılabilir. 
	Bu metotlar, genellikle sınıfın genel işlevlerini yerine getirir ve sınıfın özelliklerine erişmek için 
	kullanılır.</p>
	<b><li>Statik Değişkenler</li></b>
	<p>Statik değişkenler, sınıfın bir örneği oluşturulmadan erişilebilir ve bu değişkenler sınıfın tüm örnekleri 
	arasında paylaşılır. Bu, sınıfın durumunu takip etmek ve paylaşılan verileri saklamak için kullanışlıdır.</p>
	<b><li>Statik Sınıflar</li></b>
	<p>Statik sınıflar, yalnızca statik üyeler içeren sınıflardır ve bir örneği oluşturulamaz. 
	Bu sınıflar genellikle genel amaçlı yardımcı sınıflar olarak kullanılır ve genellikle sabitler, 
	sabit metotlar ve sabit özellikler içerir.</p>

<h1>Void Anahtar Kelimesi</h1>
<p>C# dilinde void anahtar kelimesi, bir metodun dönüş türünü belirtir ve 
bu metodun herhangi bir değer döndürmediğini ifade eder. Yani, void dönüş 
türü, metodun yalnızca bazı işlemler gerçekleştirip sonuç olarak bir değer 
döndürmeyeceği anlamına gelir.</p>
<h2>void Anahtar Kelimesinin Kullanımı</h2>
<ul>
<b><li>Değer Döndürmeyen Metotlar</li></b>
<p>PrintMessage metodu void olarak tanımlanmıştır ve sadece ekrana bir mesaj yazdırır, 
ancak herhangi bir değer döndürmez.</p>
<b><li>Olay İşleyiciler (Event Handlers)</li></b>
<p>void, genellikle olay işleyicilerinde de kullanılır. Olay işleyiciler, belirli 
bir olay gerçekleştiğinde çalıştırılan metotlardır ve genellikle değer döndürmezler.</p>
<b><li>Ana Metod (Main Method)</li></b>
<p>Main metodunun dönüş türü void olabilir. Bu metod, C# programlarının giriş noktasıdır 
ve genellikle bir değer döndürmez.</p>
</ul>