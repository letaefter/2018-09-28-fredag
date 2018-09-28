using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    // public = syns i unity
    // int = heltal
    // hejsan = namnet
    public int hejdå;

    // float = decimaltal med 7 precision
    public float george;

    // double = decimaltal med 15 precision
    public double bush;

    // string = text utan value
    public string minecraft;

    public string annotation;

    public bool sed;

    public string string1;

    // bool = något som är true/false
    public bool john;

    // char = ett tecken.
    public char dennis;

    // Use this for initialization
    void Start()
    {
        //PrintText();
        //Calculate();
        //dessa två under är samma sak funktionellt
        Debug.Log("Hej då!" + john + " " + minecraft);
        Debug.Log(string.Format("Hej då!{0} {1}", john, minecraft));
    }
    // void ska alltid vara först och sist ska det finnas en ()
    void PrintText()
    {
        Debug.Log(annotation);
        Debug.Log(minecraft);
        Debug.Log(hejdå + george);
        Calculate();

        /*Debug.LogError(
            Mathf.Sqrt(77) +
            Mathf.Sqrt(8349573468));*/
    }

    void Calculate()
    {
        Debug.Log(5 + 6);
        Debug.Log(31.74 / (7.422 + 77));
    }


    // Update is called once per frame
    // I know, tard
    void Update()
    {



    }
}
