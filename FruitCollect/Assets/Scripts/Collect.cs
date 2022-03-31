using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    int itemCount;
    public Text score;
      
    void Start()
    {
        score.GetComponent<Text>();
    }       
 
    void OnTriggerEnter(Collider cd)
    {
        if (cd.tag == "collectCilek")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 10;
            score.text = itemCount.ToString();
            //Debug.Log("Çilek" + itemCount);
        }
        if (cd.tag == "collectChocolate")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount - 5;
            score.text = itemCount.ToString();
            //Debug.Log("chocolate" + itemCount);
        }
        else if (cd.tag == "collectOrange")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 2;
            score.text = itemCount.ToString();
            //Debug.Log("Orange" + itemCount);
        }
        else if (cd.tag == "collectAvacado")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 15;
            score.text = itemCount.ToString();
            //Debug.Log("Avocado" + itemCount);
        }
        else if (cd.tag == "collectPineapple")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 7;
            score.text = itemCount.ToString();
            //Debug.Log("Pineapple" + itemCount);
        }
        else if (cd.tag == "collectWatermelon")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 8;
            score.text = itemCount.ToString();
            //Debug.Log("Watermelon" + itemCount);
        }
        else if (cd.tag == "collectCoconut")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 12;
            score.text = itemCount.ToString();
            //Debug.Log("Coconut" + itemCount);
        }
        else if (cd.tag == "collectCherry")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 1;
            score.text = itemCount.ToString();
            //Debug.Log("cherry" + itemCount);
        }
        else if (cd.tag == "collectPear")
        {
            Destroy(cd.gameObject);
            itemCount = itemCount + 4;
            score.text = itemCount.ToString();
            //Debug.Log("Pear" + itemCount);
        }
    }
}
