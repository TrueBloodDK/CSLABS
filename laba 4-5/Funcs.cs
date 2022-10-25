namespace laba4;
using System.Collections.Generic;

public static class Funcs {
    
    public static int[] FillArray(int size) {
    int[] ar = new int[size];
    for (var i = 0; i < ar.Length; i++) ar[i] = int.Parse(Console.ReadLine() ?? string.Empty);
    return ar;
    }
    
    public static void UniteAndPrint(Queue<int> queue1, Queue<int>queue2) {
        while (queue2.Count != 0) { queue1.Enqueue(queue2.Peek()); queue2.Dequeue(); }
        while (queue1.Count != 0) Console.Write($"{queue1.Dequeue()} ");   
    }
    
    public static Queue<int> FillNewQueue(int size) {
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < size; i++) queue.Enqueue(int.Parse(Console.ReadLine()!));
        return queue;
    }
 
    public static int[,] FillDoubleArrayOfInts(int x, int y) {
     var array = new int[x, y];
     for (var i = 0; i < x; i++)
     for (var j = 0; j < y; j++)
         array[i, j] = int.Parse(Console.ReadLine()!);
     return array;
    }                                                       
 
    public static string DoubleArrayToString(int[,] array) {
     var matrix = "";
         for (var i = 0; i < array.GetLength(0); i++) {
             matrix += "\n";
             for (var j = 0; j < array.GetLength(1); j++) matrix += array[i,j] + " ";
         }
     return matrix;
    }
}

