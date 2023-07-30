using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SetBits : MonoBehaviour
{

    //theory

    // one bit reperesents two values of binary like (0 0,0 1, 1 0, 1 1 )
    // when we combine 8 bits together is called one byte, and it contains 256 values of binary like (1 = 1,11 = 1,0000 = 1,00000000 = 1 and so on)
    // the sequence of 0 and 1 used in computing is called binary


    //prectical 
    [SerializeField] private int number; // enter a number to convert in binary formet
    // Start is called before the first frame update
    void Start()
    {
        PrintBinary();
    }


    // this method will print binary sequence in the console
    private void PrintBinary()
    {
        print(Convert.ToString(number, 2));
    }


}
