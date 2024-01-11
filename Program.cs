using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
         //ex1();
         //ex2();
         //ex3();
         //ex4();
         //ex5();
        // ex6();
         //ex7();
        // ex8();
        // ex9();
        //ex10();
        //ex11();
        //ex12();
        //ex13();
        //ex14();
        //ex15();
        //ex16();
        //ex17();

    }
    static void ex1()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea numarului de numere pare
        int numerePare = 0;
        foreach (int numar in secventa)
        {
            if (EstePar(numar))
            {
                numerePare++;
            }
        }

        Console.WriteLine($"Numerele pare din secventa sunt: {numerePare}");
    }

    // Funcție pentru verificarea dacă un număr este par
    static bool EstePar(int numar)
    {
        return numar % 2 == 0;
    }
    static void ex2()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Initializarea contoarelor
        int numereNegative = 0;
        int numereZero = 0;
        int numerePozitive = 0;

        // Determinarea numarului de numere negative, zero si pozitive
        foreach (int numar in secventa)
        {
            if (numar < 0)
            {
                numereNegative++;
            }
            else if (numar == 0)
            {
                numereZero++;
            }
            else
            {
                numerePozitive++;
            }
        }

        // Afisarea rezultatelor
        Console.WriteLine($"Numerele negative: {numereNegative}");
        Console.WriteLine($"Numerele zero: {numereZero}");
        Console.WriteLine($"Numerele pozitive: {numerePozitive}");
    }
    static void ex3()
    {
        Console.Write("Introduceti un numar n: ");
        int n = int.Parse(Console.ReadLine());

        // Calcularea sumei și produsului
        int suma = 0;
        int produs = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
            produs *= i;
        }

        // Afisarea rezultatelor
        Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
        Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
    }
    static void ex4()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti numarul cautat: ");
        int numarCautat = int.Parse(Console.ReadLine());

        // Determinarea pozitiei numarului in secventa
        int pozitie = GasestePozitie(secventa, numarCautat);

        // Afisarea rezultatului
        if (pozitie != -1)
        {
            Console.WriteLine($"Numarul {numarCautat} se afla pe pozitia {pozitie} in secventa.");
        }
        else
        {
            Console.WriteLine($"Numarul {numarCautat} nu se afla in secventa. Raspuns: -1");
        }
    }

    // Functie pentru gasirea pozitiei unui numar in secventa
    static int GasestePozitie(int[] secventa, int numar)
    {
        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == numar)
            {
                return i;
            }
        }

        // Daca numarul nu se gaseste in secventa, returnam -1
        return -1;
    }
    static void ex5()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea numarului de elemente egale cu pozitia
        int elementeEgaleCuPozitia = 0;

        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == i)
            {
                elementeEgaleCuPozitia++;
            }
        }

        // Afisarea rezultatului
        Console.WriteLine($"Numarul de elemente egale cu pozitia in secventa este: {elementeEgaleCuPozitia}");
    }
    static void ex6()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Verificarea daca numerele sunt in ordine crescatoare
        bool suntInOrdineCrescatoare = VerificaOrdineCrescatoare(secventa);

        // Afisarea rezultatului
        if (suntInOrdineCrescatoare)
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else
        {
            Console.WriteLine("Numerele din secventa NU sunt in ordine crescatoare.");
        }
    }

    // Functie pentru verificarea daca numerele sunt in ordine crescatoare
    static bool VerificaOrdineCrescatoare(int[] secventa)
    {
        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] < secventa[i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void ex7()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea celei mai mari si celei mai mici valori
        int ceaMaiMicaValoare = secventa[0];
        int ceaMaiMareValoare = secventa[0];

        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] < ceaMaiMicaValoare)
            {
                ceaMaiMicaValoare = secventa[i];
            }

            if (secventa[i] > ceaMaiMareValoare)
            {
                ceaMaiMareValoare = secventa[i];
            }
        }

        // Afisarea rezultatelor
        Console.WriteLine($"Cea mai mica valoare din secventa: {ceaMaiMicaValoare}");
        Console.WriteLine($"Cea mai mare valoare din secventa: {ceaMaiMareValoare}");
    }
    static void ex8()
    {
        Console.Write("Introduceti valoarea lui n pentru sirul lui Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        // Determinarea celui de-al n-lea numar din sirul lui Fibonacci
        int rezultat = Fibonacii(n);

        // Afisarea rezultatului
        Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {rezultat}");
    }

    // Functie pentru calculul celui de-al n-lea numar din sirul lui Fibonacci
    static int Fibonacii(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int anterior = 0;
            int curent = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = curent;
                curent = anterior + curent;
                anterior = temp;
            }

            return curent;
        }
    }
    static void ex9()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Verificarea daca secventa este monoton crescatore sau monoton descrescatoare
        bool monotonCrescatoare = true;
        bool monotonDescrescatoare = true;

        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] < secventa[i - 1])
            {
                monotonCrescatoare = false;
            }

            if (secventa[i] > secventa[i - 1])
            {
                monotonDescrescatoare = false;
            }
        }

        // Afisarea rezultatului
        if (monotonCrescatoare)
        {
            Console.WriteLine("Secventa este monoton crescatoare.");
        }
        else if (monotonDescrescatoare)
        {
            Console.WriteLine("Secventa este monoton descrescatoare.");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }
    }
    static void ex10()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea numarului maxim de numere consecutive egale
        int numarMaximConsecutiveEgale = 1;
        int numarCurentConsecutiveEgale = 1;

        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] == secventa[i - 1])
            {
                numarCurentConsecutiveEgale++;
            }
            else
            {
                numarCurentConsecutiveEgale = 1;
            }

            if (numarCurentConsecutiveEgale > numarMaximConsecutiveEgale)
            {
                numarMaximConsecutiveEgale = numarCurentConsecutiveEgale;
            }
        }

        // Afisarea rezultatului
        Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {numarMaximConsecutiveEgale}");
    }
    static void ex11()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        double[] secventa = new double[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = double.Parse(Console.ReadLine());
        }

        // Calculul sumei inverselor
        double sumaInverselor = 0;

        for (int i = 0; i < n; i++)
        {
            if (secventa[i] != 0)
            {
                sumaInverselor += 1 / secventa[i];
            }
            else
            {
                Console.WriteLine("Atentie: Divizare la zero. Ignorand elementul cu valoare zero.");
            }
        }

        // Afisarea rezultatului
        Console.WriteLine($"Suma inverselor secventei este: {sumaInverselor}");
    }
    static void ex12()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea numarului de grupuri de numere consecutive diferite de zero
        int numarGrupuri = 0;

        for (int i = 0; i < n; i++)
        {
            if (secventa[i] != 0)
            {
                numarGrupuri++;

                // Ignorarea celorlalte elemente consecutive diferite de zero
                while (i < n - 1 && secventa[i + 1] != 0)
                {
                    i++;
                }
            }
        }

        // Afisarea rezultatului
        Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {numarGrupuri}");
    }
    static void ex13()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea daca secventa este o secventa crescatoare rotita
        bool esteCrescatoareRotita = EsteCrescatoareRotita(secventa);

        // Afisarea rezultatului
        if (esteCrescatoareRotita)
        {
            Console.WriteLine("Secventa este o secventa crescatoare rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa crescatoare rotita.");
        }
    }

    // Functie pentru verificarea daca secventa este o secventa crescatoare rotita
    static bool EsteCrescatoareRotita(int[] secventa)
    {
        int lungime = secventa.Length;

        // Daca secventa are o singura valoare sau este deja ordonata, este considerata o secventa crescatoare rotita
        if (lungime <= 1 || EsteCrescatoare(secventa))
        {
            return true;
        }

        // Verificare daca secventa poate fi rotita pentru a deveni o secventa crescatoare
        for (int i = 0; i < lungime - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return EsteCrescatoare(RotesteStanga(secventa, i + 1));
            }
        }

        return false;
    }

    // Functie pentru verificarea daca o secventa este in ordine crescatoare
    static bool EsteCrescatoare(int[] secventa)
    {
        for (int i = 0; i < secventa.Length - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // Functie pentru rotirea unei secvente la stanga cu un anumit numar de pozitii
    static int[] RotesteStanga(int[] secventa, int pozitii)
    {
        int lungime = secventa.Length;
        int[] nouaSecventa = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            nouaSecventa[(i - pozitii + lungime) % lungime] = secventa[i];
        }

        return nouaSecventa;
    }
    static void ex14()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea daca secventa este o secventa monotona rotita
        bool esteMonotonaRotita = EsteMonotonaRotita(secventa);

        // Afisarea rezultatului
        if (esteMonotonaRotita)
        {
            Console.WriteLine("Secventa este o secventa monotona rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa monotona rotita.");
        }
    }

    // Functie pentru verificarea daca secventa este o secventa monotona rotita
    static bool EsteMonotonaRotita(int[] secventa)
    {
        int lungime = secventa.Length;

        // Daca secventa are o singura valoare sau este deja monotona, este considerata o secventa monotona rotita
        if (lungime <= 1 || EsteMonotona(secventa))
        {
            return true;
        }

        // Verificare daca secventa poate fi rotita pentru a deveni o secventa monotona
        for (int i = 0; i < lungime - 1; i++)
        {
            if (secventa[i] != secventa[i + 1])
            {
                return EsteMonotona(RotesteStanga(secventa, i + 1));
            }
        }

        return true;
    }

    // Functie pentru verificarea daca o secventa este monotona
    static bool EsteMonotona(int[] secventa)
    {
        for (int i = 0; i < secventa.Length - 1; i++)
        {
            if (secventa[i] > secventa[i + 1] || secventa[i] < secventa[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // Functie pentru rotirea unei secvente la stanga cu un anumit numar de pozitii
    static int[] RotesteStangaa(int[] secventa, int pozitii)
    {
        int lungime = secventa.Length;
        int[] nouaSecventa = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            nouaSecventa[(i - pozitii + lungime) % lungime] = secventa[i];
        }

        return nouaSecventa;
    }
    static void ex15()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea daca secventa este bitonica
        bool esteBitonica = EsteBitonica(secventa);

        // Afisarea rezultatului
        if (esteBitonica)
        {
            Console.WriteLine("Secventa este bitonica.");
        }
        else
        {
            Console.WriteLine("Secventa NU este bitonica.");
        }
    }

    // Functie pentru verificarea daca secventa este bitonica
    static bool EsteBitonica(int[] secventa)
    {
        int lungime = secventa.Length;

        // Verificare daca secventa are cel putin 3 elemente
        if (lungime < 3)
        {
            return false;
        }

        // Identificare punct de viraj (punctul in care secventa devine descrescatoare)
        int punctDeViraj = GasestePunctDeViraj(secventa);

        // Verificare daca secventa este bitonica
        return punctDeViraj != -1 && punctDeViraj != 0 && punctDeViraj != lungime - 1;
    }

    // Functie pentru gasirea punctului de viraj in secventa
    static int GasestePunctDeViraj(int[] secventa)
    {
        int stanga = 0;
        int dreapta = secventa.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
            {
                return mijloc; // Punctul de viraj a fost gasit
            }
            else if (secventa[mijloc] > secventa[mijloc - 1])
            {
                stanga = mijloc + 1; // Continua cautarea in partea dreapta
            }
            else
            {
                dreapta = mijloc - 1; // Continua cautarea in partea stanga
            }
        }

        return -1; // Nu exista punct de viraj in secventa
    }
    static void ex16()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea daca secventa este o secventa bitonica rotita
        bool esteBitonicaRotita = EsteBitonicaRotita(secventa);

        // Afisarea rezultatului
        if (esteBitonicaRotita)
        {
            Console.WriteLine("Secventa este o secventa bitonica rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa bitonica rotita.");
        }
    }

    // Functie pentru verificarea daca secventa este o secventa bitonica rotita
    static bool EsteBitonicaRotita(int[] secventa)
    {
        int lungime = secventa.Length;

        // Verificare daca secventa are cel putin 3 elemente
        if (lungime < 3)
        {
            return false;
        }

        // Identificare punct de viraj (punctul in care secventa devine descrescatoare)
        int punctDeViraj = GasestePunctDeViraj(secventa);

        // Verificare daca secventa este bitonica rotita
        return punctDeViraj != -1 && punctDeViraj != 0 && punctDeViraj != lungime - 1;
    }

    // Functie pentru gasirea punctului de viraj in secventa
    static int GasestePunctDeVirajj(int[] secventa)
    {
        int stanga = 0;
        int dreapta = secventa.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
            {
                return mijloc; // Punctul de viraj a fost gasit
            }
            else if (secventa[mijloc] > secventa[mijloc - 1])
            {
                stanga = mijloc + 1; // Continua cautarea in partea dreapta
            }
            else
            {
                dreapta = mijloc - 1; // Continua cautarea in partea stanga
            }
        }

        return -1; // Nu exista punct de viraj in secventa
    }
    static void ex17()
    {
        Console.WriteLine("Introduceti secventa de 0 si 1 separate prin spatiu:");
        string[] input = Console.ReadLine().Split(' ');

        int[] secventa = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            secventa[i] = int.Parse(input[i]);
        }

        // Verificare daca secventa este corecta si determinare nivel maxim de incuibare
        bool esteCorecta = EsteSecventaCorecta(secventa, out int nivelMaxim);

        // Afisarea rezultatului
        if (esteCorecta)
        {
            Console.WriteLine($"Secventa este corecta, cu nivelul maxim de incuibare: {nivelMaxim}");
        }
        else
        {
            Console.WriteLine("Secventa nu este corecta.");
        }
    }

    // Functie pentru verificarea daca secventa este corecta si determinarea nivelului maxim de incuibare
    static bool EsteSecventaCorecta(int[] secventa, out int nivelMaxim)
    {
        nivelMaxim = 0;
        int nivelCurent = 0;

        foreach (int paranteza in secventa)
        {
            if (paranteza == 0)
            {
                nivelCurent++;

                // Actualizare nivel maxim
                if (nivelCurent > nivelMaxim)
                {
                    nivelMaxim = nivelCurent;
                }
            }
            else if (paranteza == 1)
            {
                // Verificare daca exista paranteza inchisa fara paranteza deschisa corespunzatoare
                if (nivelCurent == 0)
                {
                    return false;
                }

                nivelCurent--;
            }
            else
            {
                // Secventa contine o valoare diferita de 0 sau 1, deci nu este o secventa corecta de paranteze
                return false;
            }
        }

        // Secventa este corecta daca nivelCurent este 0 la sfarsit
        return nivelCurent == 0;
    }
}



        