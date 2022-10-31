using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_btn : MonoBehaviour
{
    int count = 0;

   
    public
    GameObject aeroplane;
    public
    GameObject arrow;
    public
    GameObject astronaut;
    public
    GameObject axe;

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
        if (count >3 )
        {
            count = 0;
        }
        Solve();
    }
    public void Solve()
    {
        if (count == 0)
        {
             displayaeroplane();
        }
        else if(count==1)
        {
             displayArrow();
        }
        else if (count == 2)
        {
            displayastronaut();
        }
        else if (count == 3)
        {
            displayaxe();
        }


    }
    public void displayastronaut()
    {
        // count = 2;
        arrow.SetActive(false);
        aeroplane.SetActive(false);
        astronaut.SetActive(true);
        axe.SetActive(false);
        //count++;
    }
    public void displayaeroplane()
    {
        // count = 1;
        arrow.SetActive(false);
        aeroplane.SetActive(true);
        astronaut.SetActive(false);
        axe.SetActive(false);
        //count++;
    }
    public void displayArrow()
    {
        //count = 0;
        astronaut.SetActive(false);
        aeroplane.SetActive(false);
        arrow.SetActive(true);
        axe.SetActive(false);
        //count++;
    }

   
 
    public void displayaxe()
    {
        // count = 2;
        arrow.SetActive(false);
        aeroplane.SetActive(false);
        astronaut.SetActive(false);
        axe.SetActive(true);
        //count = 0;
    }

}
