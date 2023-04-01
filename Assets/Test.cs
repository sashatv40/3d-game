using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int a = 1;
    public int b = 7;
    public char sign = '-';

    // Start is called before the first frame update
    void Start()
    {
        if (sign == '+')
        {
            Sum();
        }
        if (sign == '-')
        {
            Substract();
        }
        if (sign == '/')
        {
            Delenie();
        }
        if (sign == '*')
        {
            Ymnozenie();
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Sum()
    {
        int result = a + b;
        print(result);
    }
    private void Substract()
    {
        int result = a - b;
        print(result);
    }
    private void Delenie()
    {
        if (b != 0)
        {
            int result = a / b;
            print(result);
        }
        else
        {
            print("Не делится");
        }
    }
    private void Ymnozenie()
    {
        int result = a * b;
        print(result);
    }
}