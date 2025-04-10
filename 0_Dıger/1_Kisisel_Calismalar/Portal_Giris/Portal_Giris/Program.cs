using Araç_Yönetim_Sistemi;
using Portal_Giris.NewPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();

            while (true)
            {
                Console.WriteLine("Portal");
                Console.WriteLine("1. Yeni Kullanıcı Kaydı");
                Console.WriteLine("2. Kullanıcı Girişi");
                Console.WriteLine("3. Kullanıcı Bilgilerini Sil");
                Console.WriteLine("4. Çıkış");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Kullanıcı Adı Giriniz");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Şifre Giriniz");
                        string password = Console.ReadLine();
                        Console.WriteLine("Email Giriniz");
                        string email = Console.ReadLine();
                        Console.WriteLine("İsim Giriniz");
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyisim Giriniz");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Telefon Numarası Giriniz");
                        string phoneNumber = Console.ReadLine();

                        StructPerson newUser = new StructPerson(userName, password, email, name, surname, phoneNumber);
                        users.AddUser(newUser);

                        Console.WriteLine("Yeni Kullanıcı Kaydı Yapıldı");
                        break;
                    case 2:
                        Console.WriteLine("Kullanıcı Adınızı Giriniz:");
                        string loginUserName = Console.ReadLine();
                        Console.WriteLine("Şifrenizi Giriniz:");
                        string loginPassword = Console.ReadLine();

                        bool userFound = false;
                        foreach (var user in users.GetUsers())
                        {
                            if (user.UserName.Equals(loginUserName) && user.Password.Equals(loginPassword))
                            {
                                Console.WriteLine("Kullanıcı Girişi Yapıldı");
                                userFound = true;
                                Cars cars = new Cars();
                                while (true)
                                {
                                    Console.WriteLine("Araç Yönetim Sistemi");
                                    Console.WriteLine("1. Araç Ekle");
                                    Console.WriteLine("2. Araç Listele");
                                    Console.WriteLine("3. Araç Sil");
                                    Console.WriteLine("4. Çıkış");
                                    Console.WriteLine("Seçiminizi yapınız: ");
                                    int secim_arac = Convert.ToInt32(Console.ReadLine());

                                    switch (secim_arac)
                                    {
                                        case 1:
                                            Console.WriteLine("Marka: ");
                                            EnumMarka marka = (EnumMarka)Enum.Parse(typeof(EnumMarka), Console.ReadLine());
                                            Console.WriteLine("Tip: ");
                                            EnumType tip = (EnumType)Enum.Parse(typeof(EnumType), Console.ReadLine());
                                            Console.WriteLine("Renk: ");
                                            EnumColor renk = (EnumColor)Enum.Parse(typeof(EnumColor), Console.ReadLine());
                                            Console.WriteLine("Yıl: ");
                                            EnumYear yıl = (EnumYear)Enum.Parse(typeof(EnumYear), Console.ReadLine());
                                            cars.AddCar(marka, tip, renk, yıl);
                                            break;
                                        case 2:
                                            cars.DisplayCars();
                                            break;
                                        case 3:
                                            Console.WriteLine("Silmek istediğiniz aracın indeksini giriniz: ");
                                            int index = Convert.ToInt32(Console.ReadLine());
                                            cars.RemoveCar(index);
                                            break;
                                        case 4:
                                            Console.WriteLine("Çıkış Yapıldı");
                                            return;
                                        default:
                                            Console.WriteLine("Hatalı Seçim Yaptınız");
                                            break;
                                    }
                                }
                            }
                        }

                        if (!userFound)
                        {
                            Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Kullanıcı Adı Giriniz");
                        string userNameToRemove = Console.ReadLine();

                        StructPerson? userToRemove = null;
                        foreach (var user in users.GetUsers())
                        {
                            if (user.UserName == userNameToRemove)
                            {
                                userToRemove = user;
                                break;
                            }
                        }

                        if (userToRemove.HasValue)
                        {
                            users.RemoveUser(userToRemove.Value);
                            Console.WriteLine("Kullanıcı Bilgileri Silindi");
                        }
                        else
                        {
                            Console.WriteLine("Kullanıcı Bulunamadı");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Çıkış Yapıldı");
                        return;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }
            }
        }
    }
}
