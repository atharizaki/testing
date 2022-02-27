using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan_pertama
{
     class Program
    {
        static void Main(string[] args)
        {//Begin
        
            //numeric p,l,luas
            double p, l, luas;
        
            //display 'Masukan panjangnya: '
            Console.Write("Masukkan Panjangnya = ");

            //Accept p
            p = Convert.ToDouble(Console.ReadLine());

            //Display 'Masukkan lebarnya: '
            Console.Write("Masukkan lebarnya: ");

            //Accept l
            l = Convert.ToDouble(Console.ReadLine());

            //Compute luas = p*l
            luas = p*l;


            //Display 'Luasnya= ' +luas
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya {2}", p, l, luas);
            Console.ReadKey();
   
        }//End
    }
}
