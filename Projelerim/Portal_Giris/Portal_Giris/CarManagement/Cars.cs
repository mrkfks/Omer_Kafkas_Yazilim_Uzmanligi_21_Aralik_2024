using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Yönetim_Sistemi
{
    public class Cars
    {
        private List<StructCars> carList = new List<StructCars>();

        public void AddCar(EnumMarka marka, EnumType tip, EnumColor renk, EnumYear yıl)
        {
            StructCars newCar = new StructCars(marka.ToString(), tip.ToString(), renk.ToString(), (int)yıl);
            carList.Add(newCar);
        }

        public void DisplayCars()
        {
            for (int i = 0; i < carList.Count; i++)
            {
                var car = carList[i];
                Console.WriteLine($"{i}. Marka: {car.Marka}, Tip: {car.Tip}, Renk: {car.Renk}, Yıl: {car.Yıl}");
            }
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < carList.Count)
            {
                carList.RemoveAt(index);
                Console.WriteLine("Araç başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz indeks.");
            }
        }
    }
}

