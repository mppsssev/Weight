using System;
using System.IO;
using WeigtSort;

 var weights  = new Weights();

    ShowReadyWeight();





void ShowReadyWeight()
{
    foreach(Array arr in weights.WeightArray)
    {
        List<int> intArr =  CheckCondition(arr);
           
           foreach(int i in intArr)
            {
                Console.Write(i+"|");
            }
            Console.Write("\n");
    }


}

List<int> CheckCondition(Array condWeight)
{
   List<int> arrWeight = new List<int>();

    foreach (Array arrVar in  condWeight)
    {
        if(arrVar.Length != 2)
        {
        Console.WriteLine("Сondition > 2!");
        break;
        }

        if((int)arrVar.GetValue(0) > (int)arrVar.GetValue(1))
        {
            Console.WriteLine("Error condition!");
            break;
        }

        foreach(int i in arrVar)
        {
            bool check = false;

            foreach(int k in arrWeight )
            if(k==i) check = true;
           
           if(check)
           continue;

           else
           arrWeight.Add(i);
        
        }
         arrWeight.Sort();
    } 
     return arrWeight;

}

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







