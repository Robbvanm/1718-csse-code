using System;
using System.Collections;
using System.Collections.Generic;

public class vermenigvuldiging 
{  
    public static void Main() 
{
    int teller, getal, vermenigvuldiging, tel = 1;
    var getallen = new List<int>();
    ArrayList getallenArray = new ArrayList();
    Hashtable getallenHashtable = new Hashtable();

    do{
    Console.Write("Geef een getal voor vermenigvuldiging (typ 0 om te stoppen): ");
    getal = Convert.ToInt32(Console.ReadLine());
    getallen.Add(getal);
    getallenArray.Add(getal);
    getallenHashtable.Add(tel++, getal);
    Console.Write("\nTabel: \n\n");
        for(teller = 1; teller < 11; teller++){
            vermenigvuldiging = getal*teller;
            Console.WriteLine(getal.ToString() + " x " + teller.ToString() + " = " + vermenigvuldiging.ToString());

        }
        Console.WriteLine();
        foreach (var a in getallen){
            Console.Write(a + ", ");  
        }  
        Console.WriteLine();

        foreach (var a in getallenArray){
            Console.Write(a + ", ");  
        }  
        Console.WriteLine();

ICollection key = getallenHashtable.Keys;
        foreach (var a in key)
         {
            Console.Write("getal ");
            Console.Write(a + " : " + getallenHashtable[a] + ", ");
         }
         Console.WriteLine();
    } while(getal != 0);
}
}