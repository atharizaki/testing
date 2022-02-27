using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_yang_berbeda
{
    class PersegiPanjang
    {
        //Deklarasi variabel
        private double p, l, luas;

        //method yang melewatkan nilai
        public void InputData()
        {
            //Display 'Masukkan Panjangnya: '
            Console.Write("Masukkan Panjangnya = ");

            //Accept p
            p = Convert.ToDouble(Console.ReadLine());

            //Display 'Masukkan lebarnya: '
            Console.Write("Masukkan Lebarnya: ");

            //Accept l
            l = Convert.ToDouble(Console.ReadLine());
        }

        //method yang melewatkan nilai
        public void ProsesData()
        {
            //compute luas = p*l
            luas = p * l;
        }

        //method yang mengembalikan nilai
        public double ProsesData1()
        {
            luas = p * l;
            return luas;
        }

        //method yang mengembalikan nilai yang memiliki parameter
        public double ProsesData2(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        //method yang melewatkan nilai 
        public void OutputData()
        {
            //Display 'luasnya= ' +luas
            Console.WriteLine("panjang = {0} Lebar = {1} Luasnya {2}", p l, luas);
        }

        //method yang melewatkan nilai
        public void OutputData1()
        {
            //Display 'Luasnya= '+luas
            Console.WriteLine("panjang = {0} Lebar {1} Luasnya {2}", p, l, ProsesData1());
        }

        //method dengan menggunakan parameter
        public void OutputData2(double luas)
        {
            //Display 'Luasnya= ' +luas
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya= {2}", p, l, luas);
        }


        static void Main(string[] args)
        {
            //initiate class (membuat objek baru untuk kelas)
            PersegiPanjang pp = new PersegiPanjang();
            coba cb = new coba();

            //memanggil method dari class PersegiPanjang
            pp.InputData();
            pp.ProsesData();
            pp.OutputData();
            pp.OutputData1();

            pp.OutputData2(pp.ProsesData2(pp.p, pp.l));

            //memanggil method dari class coba
            pp.OutputData2(cb.ProsesData3(pp.p, pp.l));
            Console.ReadKey();
        }
    }

    //membuat class baru 
    class coba
    {
        //method yang mengembalikan nilai yang memiliki parameter
        public double ProsesData3(double panjang, double lebar)
        {
            return panjang * lebar;
        }
    }
}
