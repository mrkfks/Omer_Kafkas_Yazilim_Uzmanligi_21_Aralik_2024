namespace _17_Day
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ArrayList
            //Türü defaultta object olduğundan her türlü ve karışık tüdeki
            //verileri alabilen ve tür ataması olmayan bir koleksiyon yapısıdır.

            //List<T>
            //Generic yoluyla tür ataması olduğundan kesin bir tür alır .
            //böylelikle bu koleksiyon hangi tür için çalışması gerektiğini bilir.

            //LinkedList<T>
            //Collections un ortalarına yada farklı indexlerine değer eklemek için kullanılır.

            //Queue<T>
            //İstenilen veri türü ile işlem yapar.
            //İlk giren ilk çıkar (fifo) mantığı ile çalışır.

            //Stack<T>
            //İstenilen veri türü ile işlem yapar.
            //Son giren ilk çıkar (lifo) mantığı ile çalışır.

            //Hashset<T>
            //sıralama algoritması eklenen değerin bellekteki hashcode büyüklüğüne göre yapılır.
            //benzersiz değerleri kendisinde saklar.

            //SortedSet<T>
            //Brnzersiz öğeleri sıralı bir şekilde saklar.

            //Dictionary<TKey, TValue>
            //Key (Anahtar) ve Value(Değer) çifti değerlerini saklar.
            //index algoritması yoktur.


            UseLinkedList useLinkedList = new UseLinkedList();
            useLinkedList.Call();

            Console.WriteLine("*******************");
            UseQueue useQueue = new UseQueue();
            useQueue.Call();

            Console.WriteLine("*******************");
            UseStack useStack = new UseStack();
            useStack.Call();

            Console.WriteLine("*******************");
            UseHashSet useHashSet = new UseHashSet();
            useHashSet.Call();

            Console.WriteLine("*******************");
            UseSortedSet useSortedSet = new UseSortedSet();
            useSortedSet.Call();



        }
    }
}
