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
        // �z�������������
        int[] points = {32, 33, 34, 35, 36};

        //�z��̗v�f�����Ԃɕ\������
        for (int i=0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        //�z��̗v�f���t���ɕ\������
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
