using System;

namespace New_Anahtar_Kelimesi_ve_Metot_Gizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * new anahtar kelimesi nesne oluşturmak için kullanılır
             * yada kalıtımda aynı isme sahip nesnelerin hata yapmılmadığını görstermek için kullanılır
             */
            A a=new A();
            B b=new B();
            a.yaz();
            //b.yaz();//bunu kaldırıp base komutu ile a classı içerisinden b ye ulaşma
            //buraya kadar normal bir class ve nesne ulaşımı 
            //Kalıtım yapalım
        }
    }
    class A:B
    {
        new public void yaz()//Burda kalıtım sonunda aynı isimde olan foksiyonlar hata varmış gibi gösterir bu engellemk için new kullanılır
        {
            base.yaz();
            Console.WriteLine("Ben A yım");
        }
    }
    class B
    {
        public void yaz()
        {
            Console.WriteLine("Ben B yim");
        }

    }
}
