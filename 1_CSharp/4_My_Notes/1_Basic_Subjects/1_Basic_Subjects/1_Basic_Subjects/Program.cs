using System;

namespace _1_Basic_Subjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PritMessage();
        }

        public static void PritMessage()
        {
            Console.WriteLine("Bu Mesaj Bir Değer Döndürmez");
        }

        class MyClassPrivate 
        {
            private int MyPrivateVariable;
        }

        class MyClassİnternal
        {
            internal int MyInternalVariable;
        }
        class MyClassProtected
        {
            protected int MyProtectedVariable;
        }
        class MyClassProtectedInternal
        {
            protected internal int MyProtectedInternalVariable;
        }
        class MyClassPublic
        {
            public int MyPublicVariable;
        }

    }
}

