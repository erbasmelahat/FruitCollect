using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C : MonoBehaviour
{
    //How fast do we change
    public float changeTime;
    //How long do we wait before changing again
    public float waitTime;

    private Color color;
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine("ChangeColor");
    }

    IEnumerator ChangeColor()
    {
        //Save our initial color
        color = text.color;

        //Get a random color to change to
        float r = Random.Range(0, 1.0f);
        float g = Random.Range(0, 1.0f);
        float b = Random.Range(0, 1.0f);

        Color newColor = new Color(r, g, b);

        float t = 0;

        while (t < 1)
        {
            //Set our color
            text.color = Color.Lerp(color, newColor, t);
            //Update our t according to how much time has passed
            t += Time.deltaTime / changeTime;
            yield return null;
        }

        //If we have a waittime, wait and then start over
        yield return new WaitForSeconds(waitTime);
        StartCoroutine("ChangeColor");
    }

}
