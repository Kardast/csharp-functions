// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;

Console.WriteLine("Hello, World!");

//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina

void StampaArray(int[] array)
{
    Console.WriteLine("il tuo array è: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("elemento " + array[i] + ", ");
    };
    Console.WriteLine("]");
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return numero * numero;
}

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }
    return arrayQuadrato;
}

//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
int[] array = { 2, 6, 7, 5, 3, 9 };

//Stampare l’array di numeri fornito a video
StampaArray(array);

//Stampa di un numero elevato al quadrato
int numero = 5;
Console.WriteLine("numero al quadrato: " + Quadrato(numero));

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
int[] arrayQuadrato = ElevaArrayAlQuadrato(array);
StampaArray(arrayQuadrato);

//(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
StampaArray(array);

//Stampare la somma di tutti i numeri
Console.WriteLine("la somma è: " + SommaElementiArray(array));

//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("la somma al quadrato è: " + SommaElementiArray(array) * SommaElementiArray(array));

//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
//ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
//A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente. (modificato) 
//Console.WriteLine("Quanti numeri vuoi inserire per creare il tuo array?");
//int myNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Hai inserito il numero " + myNum);
//int[] myArray = new int[myNum];
//Console.WriteLine("Inserisci " + myNum + " numeri");
//for (int i = 0; i < myArray.Length; i++)
//{
//    int arrayNum = Convert.ToInt32(Console.ReadLine());
//    myArray[i] = arrayNum;
//}
//StampaArray(myArray);
//int[] myArrayQuadrato = ElevaArrayAlQuadrato(myArray);
//StampaArray(myArrayQuadrato);
//StampaArray(myArray);
//Console.WriteLine("la somma è: " + SommaElementiArray(myArray));
//Console.WriteLine("la somma al quadrato è: " + SommaElementiArray(myArray) * SommaElementiArray(myArray));




//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:

//1 - Fattoriale di un numero
//2 - La sequenza di fibonacci di un numero

//1) il fattoriale di un numero può essere calcolato solo su numeri positivi:

//0! = 1
//1! = 1
//2! = 2
//3! = 6
//4! = 24
//5! = 120
//N! = ???

//Risolverla in modo ITERATIVO (FOR)
//Console.WriteLine("Inserisci un numero");
//int facNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(facFun(facNum));
//int facFun(int facNum)
//{
//    int tot = facNum;
//    if (facNum != 0)
//    {
//        for (int i = facNum; i > 1; i--)
//        {
//            tot = tot * (i - 1);
//        }
//    }
//    else
//    {
//        tot++;
//    }
//    return tot;
//}

//risolverla in modo RICORSIVO
//Console.WriteLine("Inserisci un numero");
//int userNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(factorialFunction(userNumber));

//int factorialFunction(int userNumber)
//{
//    if(userNumber > 0)
//    {
//        return userNumber * factorialFunction(userNumber - 1);
//    }
//    else
//    {
//        return 1;
//    }
//}

//n Fn
//0	0
//1	1
//2	1
//3	2
//4	3
//5	5
//6	8
//7	13
//8	21
//9	34
//10	55
//fibonacci(10) = 55
//isolverla in modo RICORSIVO
//o anche in modo ITERATIVO (FOR)

//COMPITO VACANZE
//chiedere all'utente una stringa, chiedere all'utente un chiave (numerica) che possa realizzare un CIFRATORE / DECIFRATORE del CIFRARIO DI CESARE

//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita dall’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//Mi raccomando ci sono diversi modi di integrarlo, scegliete una strategia semplice in base a quello che abbiamo spiegato:
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita

//per criptare: ogni lettera corrisponde alla lettera x posizioni dopo (ad es. 3: a = d; e = h)
//per decriptare: ogni lettera corrisponde alla lettera x posizioni prima (ad es. 3: d = a; h = e)


//chiedere all'utente se la frase è da criptare o decriptare e qual è la chiave numerica

Console.WriteLine("La frase è da criptare? Rispondere 'si' o 'no'");
string cript = Console.ReadLine();

Console.WriteLine("Qual è la chiave numerica? Inserire un numero");
int numberKey = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire la frase:");
string input = Console.ReadLine();

Cesare(cript, numberKey, input);


void Cesare(string cript, int numberKey, string input)
{
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'z' };

    //dividere le singole lettere della stringa ed inserirle in un array [c, i, a, o]
    char[] inputCharArray = input.ToCharArray();

    //se è da criptare
    if (cript == "si")
    {
        string cryptedInput = "";
        for (int i = 0; i < input.Length; i++)
        {
            int j = 0;
            for (; j < alphabet.Length; j++)
            {
                // confronto la lettera iesima della parola con la lettera jesima dell'alfabeto
                if (inputCharArray[i] == alphabet[j])
                {
                    break;
                }
            }
            //usare la chiave numerica per criptare le lettere
            if (j + numberKey > alphabet.Length - 1)
            {
                //riunire le lettere in una stringa
                cryptedInput += alphabet[j + numberKey - alphabet.Length];
            }
            else
            {
                cryptedInput += alphabet[j + numberKey];
            }
        }
        Console.WriteLine(cryptedInput);
    }

    //se è da decriptare
    else
    {
        string decryptedInput = "";
        for (int i = 0; i < input.Length; i++)
        {
            int j = 0;
            for (; j < alphabet.Length; j++)
            {
                if (inputCharArray[i] == alphabet[j])
                {
                    break;
                }
            }
            if (j - numberKey < 0)
            {
                decryptedInput += alphabet[j - numberKey + alphabet.Length];
            }
            else
            {
                decryptedInput += alphabet[j - numberKey];
            }
        }
        Console.WriteLine(decryptedInput);
    }
}