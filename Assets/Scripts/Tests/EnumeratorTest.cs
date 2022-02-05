using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorTest : MonoBehaviour
{
    static List<int> _list = new List<int>();
   static IEnumerable _enumerable = _list;
   static IEnumerator enumerator = _enumerable.GetEnumerator();
    void Start()
    {
        enumerator.MoveNext();
        Console.WriteLine(enumerator.Current);
        count();
    }

    void count()
    {
        while (enumerator.MoveNext() != false)
        {
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
        }
        
    }

}
