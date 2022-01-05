﻿using System;
using array.Helper;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] Array = new int[4] {10, 20, 30, 40};
        //    Array[0] = 10; 
        //    Array[1] = 20; 
        //    Array[2] = 30; 
        //    Array[3] = 40; 

           for (int i = 0; i < Array.Length; i++)
             {
                System.Console.WriteLine($"Percorrer Array com for : indice {i} é {Array[i]}");
             }

           foreach (var ArrayLength in Array)
             {
                 System.Console.WriteLine($"Percorrer Array com foreach : {ArrayLength}");
             }

             int[,] arrayMulti = new int[5, 2]
             {
                 { 10, 20 },
                 { 30, 40 },
                 { 50, 60 },
                 { 70, 80 },
                 { 90, 100 }
             };

             for (int linha = 0; linha < arrayMulti.GetLength(0); linha++)
             {
                 for (int coluna = 0; coluna < arrayMulti.GetLength(1); coluna++)
                 {
                     System.Console.WriteLine($"A linha {linha} e coluna {coluna} = {arrayMulti[linha, coluna]}");
                 }
             }

             //Ordenando um array Bubble sorte

             int[] arrayNum = new int[8] {5, 2, 7, 4, 6, 1, 3, 6};

             OrdenarArray ordArray = new OrdenarArray();
             System.Console.WriteLine("Array original:");
             ordArray.imprimirArray(arrayNum);

             ordArray.OrdenarBubbleSorte(ref arrayNum);
             System.Console.WriteLine("Array ordenado Bubble Sort:");
             ordArray.imprimirArray(arrayNum);
         }
    }
}