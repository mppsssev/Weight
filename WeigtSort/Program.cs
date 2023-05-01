using System;
using System.IO;
using WeigtSort;

 var weights  = new Weights();

    ShowConsoleAllWeight(weights.WeightArray);


void ShowConsoleAllWeight(Array _weights)
 {
    foreach(Array arrayFill_1 in _weights)
    {
        Console.Write("Сondition:"+ Array.IndexOf(_weights,arrayFill_1)+"\n");
        foreach(Array arrayFill_2 in arrayFill_1)
        {

            foreach(var arrayFill_3 in arrayFill_2)
            {
                Console.Write(arrayFill_3);
            }
            Console.Write(" ");
        }
         Console.Write("\n \n");
    } 
 }







