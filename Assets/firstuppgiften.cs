using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstuppgiften : MonoBehaviour
{
    //variabler
    public string mening1;
    public string mening2;
    public string mening3;
    public float number1;
    public float triangelbas1;
    public double angleOfSlices;
    public double numberOfCakeSlices;
    public string username;
    public float radius;
    public float damage;
    public float life;
    public int demons;
    public float maxDamage;
    public float minDamage;
    public double count;
    public float countMulti = 13;
    public float playerMaxLife = 3500;
    public float playerResist = 0.38f;
    public float enemyDamage = 758;
    //funktioner
    void Uppgift1()
    {
        Debug.Log(string.Format("Uppgift 1:{0}", (963f * 421f) - (175463f / 87f)));
    }
    void Uppgift2a()
    {
        Debug.Log(mening1);
    }
    void Uppgift2b()
    {
        Debug.Log(mening2);
    }
    void Uppgift2c()
    {
        Debug.Log(mening3);
    }
    void Uppgift3()
    {
        Debug.Log(number1 + " " + "to the power of 2 equals" + " " + (Mathf.Pow(number1, 2)));
        Debug.Log("square root of" + " " + number1 + " " + "equals" + " " + (Mathf.Sqrt(number1)));
    }
    void Uppgift4()
    {
        Debug.Log("a triangle with base:" + " " + triangelbas1 + " " +
            "and height: 8 has an area of" + " " + (8 * triangelbas1) / 2 + " m^2");
    }
    void Uppgift5a()
    {
        Debug.Log("if the angle of every slice is" + " " + angleOfSlices + " " +
            "degrees, then you can cut the cake into" + " " + (360 / angleOfSlices) + " " + "slices");
    }
    void Uppgift5b()
    {
        Debug.Log("if you want to cut a cake into" + " " + numberOfCakeSlices + " " +
            "slices, then the angle of those slices will be" + " " +
            (360 / numberOfCakeSlices) + " " + "degrees");
    }
    void Uppgift6()
    {
        Debug.Log("Boss" + " " + username + " " + "of Doom");
    }
    void Uppgift7()
    {
        Debug.Log("the total volume of 2978 globes with a radius of:" + " " + radius + " " + "is" + " " +
            (((Mathf.PI) * 4 * (Mathf.Pow(radius, 3))) / 3) * 2978);
    }
    void Uppgift8()
    {
        Debug.Log("with" + " " + damage + " " + "damage it takes you" + " " + (890000 / damage) + " " +
            "hits to defeat a demon with 890000 hitpoints");
    }
    void Uppgift8a()
    {
        Debug.Log("with" + " " + damage + " " + "damage it takes you" + " " + Mathf.Ceil(life / damage) + " " +
            "hits to take down a demon with" + " " + life + " " + "hitpoints");
    }
    void Uppgift8b()
    {
        Debug.Log("with" + " " + damage + " " + "damage it takes you" + " " + Mathf.Ceil(life / damage * demons) + " " +
            "hits to defeat" + " " + demons + " " + "demons. that's" + " " + Mathf.Ceil(life / damage) + " " + "hits per demon!");

    }
    void Uppgift8c()
    {
        Debug.Log("if your attacks do from" + " " + minDamage + " " + "to" + " " +
            maxDamage + " " + "damage and the demons have" + " " +
            life + " " + "hitpoints then the most attacks it can take you to kill one demon is" + " " +
            Mathf.Ceil(life / minDamage) + " " + "and the least amount of attacks it can take you is" + " " +
            Mathf.Ceil(life / maxDamage) + " " + "but on average it will take you" + " " +
            Mathf.Ceil(life / ((maxDamage + minDamage) / 2)) + " " + "hits to kill one demon");
    }
    void Uppgift9()
    {
        count = count * 2;
        Debug.Log(((count / 2)) + " " + "times two equals" + " " + count);
    }
    void Uppgift10()
    {
        countMulti = countMulti * 3 * 2;
        Debug.Log(countMulti);
    }
    void Uppgift11()
    {
        Debug.Log("you have" + " " + playerMaxLife + " " + "hitpoints and an enemy attacks you for" + " " +   (playerMaxLife - (enemyDamage * playerResist)));
    }
    // Use this for initialization
    void Start()
    {
        /*Uppgift1();
        Uppgift2a();
        Uppgift2b();
        Uppgift2c();
        Uppgift3();
        Uppgift4();
        Uppgift5a();
        Uppgift5b();
        Uppgift6();
        Uppgift7();
        Uppgift8a();
        Uppgift8b();
        Uppgift8c();
        Uppgift11();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}