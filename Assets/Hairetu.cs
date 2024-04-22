using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hairetu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化する
        int[] points = {32, 33, 34, 35, 36};

        //配列の要素を順番に表示する
        for (int i=0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        //配列の要素を逆順に表示する
        for (int i =points.Length-1;i>=0;i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
