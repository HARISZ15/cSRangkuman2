using System;
using System.Collections,Generic;
// ragkuman pertemuan 2

namespace pertemuan2
{
    
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            // Operatur Aritmatika
            var penjumlahan = 10 + 5;
            var pengurangan = 10 - 5;
            var perkalian = 10 * 5;
            var pembagian = 10 /5;
            var modulo = 10 %3;
            Console.WriteLine("Hasil penjumlahan :" + penjumlahan);
            Console.WriteLine("Hasil pengurangan :" + pengurangan);
            Console.WriteLine("Hasil perkalian :" + pembagian);
            Console.WriteLine("Hasil pembagian :" + pembagian);
            Console.WriteLine("Hasil modulo :" + modulo);
            */
           /* 
            // Operator Penugasan
            int a = 10;
            //int b = 5;

           //contoh 1
           // b = b + 5;
           //atau
          // b += 5;
          // contoh 2
          a += 5; // a = a + 5 // 15
          Console.WriteLine("Hasilnya adalah : " + a);
          a -= 5; // a = a - 5 // 10
          Console.WriteLine("Hasilnya adalah : " + a);
          a *= 5; // a = a * 5 // 50
          Console.WriteLine("Hasilnya adalah : " + a);
          a /= 5; // a = a / 5 // 10
          Console.WriteLine("Hasilnya adalah : " + a);
          a %= 3; // a = a % 5 // 1
          Console.WriteLine("Hasilnya adalah : " + a);
          */

          // increment & decrement
          /*int a = 5;

         Console.WriteLine("++a nilainya = " + ++a);
         Console.WriteLine("a++ nilainya = " + a++);
         Console.WriteLine("a nilainya = " + a);
         Console.WriteLine("=========================");

         int b = 10;

         Console.WriteLine("--b nilainya = " + --b);
         Console.WriteLine("b-- nilainya = " + b--);
         Console.WriteLine("b nilainya = " + b);
         */
         
         /*
         // Operator perbandingan 
         int a = 10;
         int b = 5;

         Console.WriteLine(a != b);//true
         Console.WriteLine(a == b);//false
         Console.WriteLine(a > b);//true
         Console.WriteLine(a < b);//false
         Console.WriteLine(a >= 10);//true
         Console.WriteLine(b <= 5);//true
         */

         /*
         int a = 10;

         namespace name = "Joni";
         
         // if (a == 10 || name == "Jon") //benar
         if (a == 10 && name == "Jon") // salah
         // if (a != 10 || name == "Jon") // benar
         {
            Console.WriteLine("Benar");
         }
         else 
         {
            Console.WriteLine("Salah");
         }
         */
         /*
         // Array
         string[] divisiDNCC = { "Game", "Web", "Mobile", "Jaringan", "Data", "Mulmed" };
         
         Console.WriteLine(divisiDNCC[0]);
         Console.WriteLine(divisiDNCC[1]);
         Console.WriteLine(divisiDNCC[2]);
         Console.WriteLine(divisiDNCC[3]);
         Console.WriteLine(divisiDNCC[4]);
         Console.WriteLine(divisiDNCC[5]);

         int[,] number = {
                           {1, 2}, //indeks 0
                           {3, 4}  //indeks 1
                         };
         Console.WriteLine(number[0, 1]);
         Console.WriteLine(number[1, 0]);
         Console.WriteLine("=================");

         int[,,] arr = {{{1, 2}, {3,4}}, {{5, 6}, {7, 8}}};
         Console.WriteLine(arr[0, 1, 1]);
         */

         // List
         /*
         var names = new List<string> { "Klowor", "Joni", "Memet" };
         for (int i = 0; i < names.Count; i++)
         {
            Console.WriteLine(names[i]);
         }
         Console.WriteLine("==============");

         //add()
         names.Add("Eyang");
         
         for (int i = 0; i < names.Count; i++)
         {
            Console.WriteLine(names[i]);
         }
         Console.WriteLine("==================");  
        
         names.AddRange(new string[2] {"Jono", "Adi", });
         for (int i = 0; i < names.Count; i++)
         {
            Console.WriteLine(names[i]);
         }

         //Remove
         names.Remove("Ucup");
         Console.WriteLine("===============");
         for (int i = 0; i < names.Count; i++)
         {
            Console.WriteLine(names[i]);
         }

         //Remove ot
         names.RemoveAt(0);
         Console.WriteLine("================");
         for (int i = 0; i < names.Count; i++)
         {
            Console.WriteLine(names[i]);
         }
         */

         //Pengkondisian
         /*
         int a = 9;
         int b = 8;
         if (a<b) // tidak terpenuhi
         */
         /*
         int nilai = 80;
         if (nilai >= 85) 
         {
            Console.WriteLine("Grade A");
         }
         else if (nilai >= 78) 
         {
            Console.WriteLine("Grade B");
         }
         else if (nilai >= 70)
         {
            Console.WriteLine("Grade C");
         }
         else 
         {
            Console.WriteLine("Grade D");
         }

         Console.WriteLine("============");

         switch (nilai)
         {
            case >= 85:
            Console.WriteLine("Grade A");
            break;
            case >= 78:
            Console.WriteLine("Grade B");
            break;
            case >= 70:
            Console.WriteLine("Grade C");
            break;
            default:
            Console.WriteLine("Grade D");
            break;
         }
         */
         /*
         // Ternary Operator
         //string hasil = (5 > 6) ? "Benar" : "Salah"; // Salah
         striing hasil = (5 < 6) ? "Benar" : "Salah"; // Benar
         Console.WriteLine(hasil);
         */
         /*
          var names = new List<string> {"Ucup", "Memet", "Joni"}
          //int i = 0
          for (i; i < 3; i++)
          {
            Console.WriteLine(names[i]);
          } 
         */

         //while
         /*
         int i = 0;
         while (i < 3)
         {
            Console.WriteLine(i);
            i++;
         }
         Console.WriteLine("========");
          int j = 0
          do 
          {
            Console.WriteLine([i]);
          }
          while (j < 3)
          */

          /*
          var names = new List<string> {"Ucup", "Memet", "Joni"};
          foreach (var name in names) {
            Console.WriteLine(name);
          }
          */
         /*
          // Break
          for (int i = 0; i < 10; i++)
          {
            Console.WriteLine(i);
            if (i == 5)
            {
                break;
            }
            Console.WriteLine("Game");
          }

          // Continue
          for (int i = 0; i < 10; i++)
          {
            
            if (i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(i);
          }
          */
         //Program fungsi = new Program();
         //fungsi.FungsiCetak(); 
         FungsiCetak();

         int hasil = Tambah();
         Console.WriteLine(hasil);
         Tampil("Game")
        }
        

          static void FungsiCetak()
         //public void FungsiCetak()
          {
            Console.WriteLine("Halo guys, apakah kabar kalian baik-baik saja");
          }
          static int Tambah()
          {
            int a = 10;
            int b = 5;

            return a + b;

          }

          static void Tampil(string name){
            Console.WriteLine("halo "+ name);
          }
    }
}


