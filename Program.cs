﻿// See https://aka.ms/new-console-template for more information
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
