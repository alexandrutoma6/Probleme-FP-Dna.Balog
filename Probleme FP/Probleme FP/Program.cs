using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_FP
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1();
            //p3();
            //p14();
            //p15();
            //p19();
            //p36();
            //p24();
            //p49();
            //p50();

        }
        /// <summary>
        /// Problema 50 va cuprinde problemele 50-54!
        /*50. Functia care determina daca un vector dat e ordonat crescator.
        51. Functia care determina minimul unui vector dat.
        52. Functia care determina daca un vector dat are numai elem impare.
        53. Functia care determina daca un vector dat are numai elem pare.
        54. Functia care determina raportul dintre elem pare si elem impare dintr-un vector.*/
        /// </summary>
        private static void p50()
        {
            Console.Write("numarul de elemente din vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++) //citim de la tastatura elementele vectorului 
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            int minim = int.MaxValue;
            int paritate = 0, imparitate = 0, crescator = 0;
            int numar = 0;//folosim variabila `numar` pentru a verifica monotonia vectorului
            for (int i = 0; i < n; i++) //parcurgem vectorul
            {
                if (v[i] <= minim)
                    minim = v[i]; //cel mai mic element din vector devine minim
                if (v[i] < numar) //daca elementul v[i-1] este mai mare decat v[i] => elementele nu sunt ordonate crescator
                    crescator--;
                numar = v[i];
                if (v[i] % 2 == 0) 
                    paritate++; //daca elementul este par se aduna in `paritate`
                if (v[i] % 2 == 1)
                    imparitate++;//daca elementul este impar se aduna in `imparitate`
            }
            if (crescator == 0)
                Console.WriteLine("vectorul este ordonat crescator");
            if (paritate == n)
                Console.WriteLine("toate numerele din vector sunt pare");
            if (imparitate == n)
                Console.WriteLine("toate numerele din vector sunt impare");
            Console.WriteLine($"elementul minim din vector este {minim}");
            if(imparitate != n)
                Console.WriteLine($"raportul dintre el pare si cele impare este {(double)paritate / imparitate}"); //pentru a se afisa operatia cu zecimane, convertim operatia in double

            
        }

        /// <summary>
        /// . Sa se scrie o functie care calculeaza media aritmetica a elementelor pare dintr-un vector de numere intregi.
        /// </summary>
        private static void p49()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++) //initializam vectorul si atribuim valori elementelor
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            int count = 0;
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0) //daca nr este par atunci se aduna si se contorizeaza cate elemente pare sunt 
                {
                    suma += v[i];
                    count++;
                }
            }
            Console.WriteLine($"Media aritmetica a numerelor pare din vectorul v este : {suma/count}");

        }

        /// <summary>
        /// Se citeşte un număr natural. Câte cifre conţine ?
        /// </summary>
        private static void p24()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int save = n;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine($"Numarul {save} are {count} cifre");
        }

        /// <summary>
        /// Scrie o metodă care primește ca parametru un număr natural x și apoi afișează:
        /// -cifrele numărului(în ordine inversă)
        /// -suma cifrelor
        ///  n == 21304
        ///  Cifrele numărului sunt: 4, 0, 3, 1, 2,
        ///  Suma cifrelor este: 10
        /// </summary>
        private static void p36()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int suma = 0; 
            Console.Write($"Cifrele numarului {x} sunt :");
            while (x != 0)
            {
                Console.Write($" {x % 10},");
                suma += x % 10;
                x /= 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma cifrelor este: {suma}");
        }

        /// <summary>
        /// Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de
        /// genul: Ce doriţi să calculăm? Aria sau perimetrul?. Dacă se va răspunde prin ‘aria’ atunci se
        /// va calcula şi afişa aria, altfel perimetrul.
        /// </summary>
        private static void p19()
        {
            //introducem numerle a b c
            Console.Write("Intorduceti numarul a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Intorduceti numarul b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Intorduceti numarul c: ");
            int c = int.Parse(Console.ReadLine());

            if (a < 0 || b < 0 || c < 0) //verificam ca numerele sa fie pozitive, altfel nu se pot calcula aria si perimetrul
            {
                Console.WriteLine("Deoarece unul sau mai multe numere sunt negative, nu se poate calcula aria/perimetrul!");
            }
            else //daca nr sunt pozitive
            {
                Console.WriteLine("Alegeti ce doriti sa calculati:");
                Console.WriteLine("1.PERIMETRUL");
                Console.WriteLine("2.ARIA");
                int j = int.Parse(Console.ReadLine()); //se alege ce sa se calculeze
                switch(j)
                {
                    case 1: //daca s-a ales perimetrul
                        Console.WriteLine("Se va calcula Perimetrul");
                        Console.WriteLine("...");
                        Console.WriteLine($"Perimetrul = {a + b + c}");
                        break;
                    case 2: //daca s-a ales aria
                        Console.WriteLine("Se va calcula Aria");
                        Console.WriteLine("...");
                        Console.WriteLine($"Aria = {a * b * c}");
                        break;
                }

            }
        }

        /// <summary>
        /// Scrieţi un program care să calculeze factorialul unui număr întreg n.
        /// </summary>
        private static void p15()
        {
            Console.Write("n = "); //introducem numarul n
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {factorial(n)}");
        }
        
        /// <summary>
        /// functia `factorial` calculeaza factorialul numarului n
        /// </summary>
        /// <param name="n"> numar </param>
        /// <returns></returns>
        private static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

        /// <summary>
        /// Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, şi si 
        /// determine cel mai mic număr şi cel mai mare număr citit
        /// </summary>
        private static void p14()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int minim = int.MaxValue; //initializam minim cu cea mai mare valoare int
            int maxim = int.MinValue; //initializam maxim cu cea mai mica valoare int
            while (n != 0) //cat timp n e diferit de 0
            {
                if (n >= maxim) //daca n este mai mare ca maxim, devine maxim
                    maxim = n;
                if (n <= minim) //daca n este mai mic ca minim, devine minim
                    minim = n;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"MAXIM = {maxim}");
            Console.WriteLine($"MINIM = {minim}");
        }

        /// <summary>
        /// Fie i,j,k. Să se determine restul împărţirii numărului natural i^j la k.
        /// </summary>
        private static void p3()
        {
            Console.Write("Introduceti baza i: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Introduceti exponentul j: ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Restul împărţirii numărului natural {Math.Pow(i,j)} la {k} este {Math.Pow(i, j) % k}");

        }

        /// <summary>
        /// Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si
        /// invers utilizand instructiunea switch.
        /// </summary>
        private static void p1()
        {
            Console.WriteLine("numele tipului de grad: "); //se alege tipul de grad initial 1.C 2.F
            Console.WriteLine("1.Celsius  2.Fahrenheit");
            int tip_grad = int.Parse(Console.ReadLine());
            Console.Write("grad: "); //se introduce numarul gradului
            int grad = int.Parse(Console.ReadLine());
            switch(tip_grad)
            {
                case 1: //daca initial s-a ales Celsius (1), se va face conversia din C-->F
                    Console.WriteLine("Conversia din grade celsiuis in faranheit");
                    Console.WriteLine($"{grad} grade Celsius = {(grad*1.8)+32} grade Farenheit");
                    break;
                case 2:////daca initial s-a ales Farenheit (2), se va face conversia din C<--F
                    Console.WriteLine("Conversia din grade farenheit in celsius");
                    Console.WriteLine($"{grad} grade Farenheit = {(grad -32)/1.8} grade Celsius");
                    break;
            }
        }
    }
}
