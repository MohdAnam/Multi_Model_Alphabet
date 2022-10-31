using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_btn : MonoBehaviour
{

    int count = 0;

    public GameObject obj1;

    public GameObject obj2;

    public GameObject obj3;

    public GameObject obj4;

    // public GameObject obj5;

    void Start()
    {

    }
    public void pervious()
    {
        count--;
        if (count < 0)
        {
            count = 3;
        }
        Solve();

    }
    public void Next()
    {
        count++;
        if (count > 3)
        {
            count = 0;
        }
        Solve();
    }

    public void Solve()
    {
        if (count == 0)
        {
            displayobj1();
        }
        else if (count == 1)
        {
            displayobj2();
        }
        else if (count == 2)
        {
            displayobj3();
        }
        else if (count == 3)
        {
            displayobj4();
        }/*
         else if (count == 4)
         {
             displayobj5();
         }*/


    }
    public void displayobj1()
    {
        //count = 0;
        obj1.SetActive(true);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        //obj5.SetActive(false);
        //  count++;
    }

    public void displayobj2()
    {
        // count = 1;
        obj1.SetActive(false);
        obj2.SetActive(true);
        obj3.SetActive(false);
        obj4.SetActive(false);
        //obj5.SetActive(false);
        // count++;
    }
    public void displayobj3()
    {
        // count = 2;
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(true);
        obj4.SetActive(false);
        // obj5.SetActive(false);
        //  count++;
    }

    public void displayobj4()
    {
        // count = 2;
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(true);
        //  obj5.SetActive(false);
        // count = 0;
    }
    /*
    public void displayobj5()
    {
        //count = 0;
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(true);
        //  count++;
    }*/

}
