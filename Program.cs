using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("", 0,0,0);
            MultiBuilding multibuilding = new MultiBuilding("", 0, 0, 0);
            building.Print();
            multibuilding.Print();

              Console.ReadKey();
        }
    }
    class Building
    {
       public string  adres;
       public int dlina;
        public int shirina;
        public int  visota;

        public string Adres
        {
            set

            {
                adres = value;
            }
            get
            {
                return adres;
            }

        }
        public int Dlina
        {
            set

            {
                if (value > 0) dlina = value;
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }

            }
            get
            {
                return dlina;
            }

        }
        public int Shirina
        {
            set

            {
                if (value > 0) shirina = value;
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }

            }
            get
            {
                return shirina;
            }

        }
        public int Visota
        {
            set

            {
                if (value > 0) visota = value;
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }

            }
            get
            {
                return visota;
            }

        }
        public Building()
        {

        }


        public Building(string adres, int dlina, int shirina, int visota)
        {
            Console.WriteLine("Адрес");
            this.adres=adres= Console.ReadLine();
            Console.WriteLine("Длина");

            this.dlina =dlina =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ширина");
            this.shirina = shirina =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Высота");
            this.visota = visota = Convert.ToInt32(Console.ReadLine());

         }
        public void Print()
        {
            Console.WriteLine("Адрес {0}, длина {1}, ширина {2}, высота {3}", adres,dlina,shirina,visota) ;
        }


    }
    sealed class MultiBuilding : Building

    {

        int etaj;

        public int Etaj
        {
            set

            {
                if (value > 0) etaj = value;
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }

            }
            get
            {
                return etaj;
            }


        }
        public MultiBuilding(string adres, int dlina, int shirina, int visota)
           
           
        {
            this.adres = adres;
            this.dlina = dlina;
            this.shirina = shirina;
            this.visota = visota;
            Console.WriteLine("Этажность");
            etaj = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {

            if (etaj != 0)
            {
                base.Print(); Console.Write("этажей {0}", etaj);

            }
        }
    }
           

    
        




    


}
