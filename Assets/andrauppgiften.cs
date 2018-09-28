using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andrauppgiften : MonoBehaviour
{
    public float userValue = 7;
    public int diceTally = 10;
    public int dragonHP;
    public int playerHP;
    public int dragonDmg;
    public int rngForIfDragonHits;
    public int playerDmg;
    public int rngForIfDragonHasDoubleHP;
    public int rngForIfPlayerInstaKills;
    public string dragonHitMissPrompt;
    public string string2;
    public int playerDmgMax;
    public int playerDmgMin;
    public int randomNumberGameNumber;
    public int previousRandomNumber;
    // Use this for initialization

    void Uppgift1()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = userValue + 2;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = userValue / 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(userValue);
        }
    }
    void Uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(diceTally = diceTally - Random.Range(1, 7) + Random.Range(1, 7));
            if (diceTally >= 20)
            {
                Debug.LogError("YOU GOT OVER 20 POINTS AND WON THE GAME");
            }
            else if (diceTally <= 0)
            {
                Debug.LogError("YOU GOT BELOW 0 POINTS AND LOST, LOSER");
            }

        }
    }
    void Uppgift3Update2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rngForIfDragonHits = Random.Range(1, 3);
            rngForIfPlayerInstaKills = Random.Range(1, 21);
            playerDmg = Random.Range(5, 26);
            dragonDmg = Random.Range(10, 21);
            if (rngForIfDragonHits == 1)
            {
                dragonHitMissPrompt = "The dragon hit you for" + " " + dragonDmg + " " + "damage, you have";
                string2 = " " + "Hitpoints left";

            }
            if (rngForIfDragonHits == 2)
            {
                dragonDmg = 0;
                dragonHitMissPrompt = "The dragon missed his attack! You still have";
            }
            if (rngForIfPlayerInstaKills == 1)
            {
                playerDmg = dragonHP * 17;

            }
            else
            {
                playerDmg = (playerDmg + 0);
            }
            //string2 = "damage left"
            Debug.Log((dragonHitMissPrompt) + " " + (playerHP = playerHP - dragonDmg) + (string2));
        }
    }
    void Uppgift3Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rngForIfDragonHits = Random.Range(1, 3);
            rngForIfPlayerInstaKills = Random.Range(1, 21);
            dragonDmg = Random.Range(10, 21);
            playerDmg = Random.Range(playerDmgMin, playerDmgMax);


            if (rngForIfPlayerInstaKills == 1)
            {
                playerDmg = playerDmg + (dragonHP * dragonHP);
            }
            if (rngForIfDragonHits == 1 && rngForIfPlayerInstaKills == 1)
            {
                Debug.LogError("The dragon hit you for" + " " + dragonDmg + " " + "damage, you have" + " " +
                    (playerHP = playerHP - dragonDmg) + " " + "HP left. Meanwhile you critically struck the dragon for" + " " +
                    playerDmg + " " + "damage! The dragon has been completely obliterated, you win");
            }
            else if (rngForIfDragonHits == 2 && rngForIfPlayerInstaKills == 1)
            {
                Debug.LogError("The dragon missed his attack! you have" + " " + playerHP + " " +
                    " HP left. Meanwhile you critically struck the dragon for" + " " +
                    playerDmg + " " + "damage! The dragon has been completely obliterated, you win");
            }
            else if (rngForIfDragonHits == 1 && rngForIfPlayerInstaKills >= 2)
            {
                Debug.Log("The dragon hit you for" + " " + dragonDmg + " " + "damage, you have" + " " +
                    (playerHP = playerHP - dragonDmg) + " " + "HP left." + " " + "Meanwhile you hit the dragon for" + " " + playerDmg + " " +
                    "damage, the dragon has" + " " + (dragonHP = dragonHP - playerDmg) + " " + "HP left.");
            }
            else if (rngForIfDragonHits == 2 && rngForIfPlayerInstaKills >= 2)
            {
                Debug.Log("The dragon missed his attack! you have" + " " + playerHP + " " +
                    "HP left. Meanwhile you hit the dragon for" + " " +
                    playerDmg + " " + "damage, the dragon has" + " " + (dragonHP = dragonHP - playerDmg) + " " + "HP left.");
            }
        }
        if (playerHP <= 0)
        {

            Debug.LogError("You have been slain by the dragon and lost.");
        }
        if (dragonHP <= 0)
        {
            Debug.LogError("You win, the dragon is dead.");
        }
    }
    void Uppgift3start()
    {
        playerDmgMin = Random.Range(1, 10);
        playerDmgMax = Random.Range(20, 30);
        rngForIfDragonHasDoubleHP = Random.Range(1, 11);
        dragonHP = (Random.Range(100, 151));
        playerHP = 100;
        if (rngForIfDragonHasDoubleHP == 1)
        {
            dragonHP = Random.Range(100, 151) * 2;
        }
        else
        {
            dragonHP = Random.Range(100, 151);
        }
        Debug.Log("in this round the dragon has" + " " + dragonHP + " " +
            "hitpoints and it has a 50% chance to do from 10 to 20 damage with each strike. And the player has" + " " +
            (playerHP) + " " + "hitpoints and a chance to do from" + " " +
            (playerDmgMin) + " " + "to" + " " + playerDmgMax + " " + "hitpoints worth of damage with every strike.");
    }
    void Uppgift5Start()
    {
        previousRandomNumber = 0;
    }
    void Uppgift5Update()
    {

        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.H))
        {
            randomNumberGameNumber = Random.Range(1, 101);

            if (Input.GetKeyDown(KeyCode.Y))
            {

                if (randomNumberGameNumber >= previousRandomNumber)
                {
                    Debug.Log(randomNumberGameNumber + " " + "is bigger than" + " " + previousRandomNumber);
                }
            }
        }
    }
    // Update is called once per frame
    void Start()
    {
        Uppgift5Start();
    }
    void Update()
    {
        Uppgift5Update();
    }
}
