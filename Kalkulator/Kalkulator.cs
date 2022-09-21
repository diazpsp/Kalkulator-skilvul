using System;

namespace Kalkulator
{
    class Program
    {
       
       

        static void Main(string[] args)
        {
            float c = 0.0f;
            Console.Write("Silakan Pilih\n");
            Console.Write("1. Penambahan\n");
            Console.Write("2. Pengurangan\n");
            Console.Write("3. Perkalian\n");
            Console.Write("4. Pembagian\n");

            int pilih = Convert.ToInt32(Console.ReadLine());
            if (pilih == 1){
                Console.Write("Angka A : ");
                float a = Single.Parse(Console.ReadLine());
                Console.Write("Angka B : ");
                float b = Single.Parse(Console.ReadLine());
                c = a + b;
                Console.Write("Value = {0}",c);

            }if(pilih == 2){
                Console.Write("Angka A : ");
                float a = Single.Parse(Console.ReadLine());
                Console.Write("Angka B : ");
                float b = Single.Parse(Console.ReadLine());
                c = a - b;
                Console.Write("Value = {0}",c);

            }if(pilih == 3){
                Console.Write("Angka A : ");
                float a = Single.Parse(Console.ReadLine());
                Console.Write("Angka B : ");
                float b = Single.Parse(Console.ReadLine());
                c = a * b;
                Console.Write("Value = "+c);
                
            }if(pilih == 4){
                Console.Write("Angka A : ");
                float a = Single.Parse(Console.ReadLine());
                Console.Write("Angka B : ");
                float b = Single.Parse(Console.ReadLine());
                c = a / b;
                Console.Write("Value = {0}",c);

            }else{
             
            }
            
           Console.ReadKey();
        }
    }
    
}
