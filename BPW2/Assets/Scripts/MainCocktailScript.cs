using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCocktailScript : MonoBehaviour
{
    int[] tastes = new int[5];
    int[] profile = new int[3]; //becomes more once you add more profiles !!! 0 is nothing !!!

    int floralLvl;
    int metallicLvl;
    int fruityLvl;
    //etc

    string MainTasteName;
    string SecondaryTasteName;
    string CharacterProfileName;

    void addIngredient(int sweet, int sour, int salty, int bitter, int umami, int character, int characterLvl)
    {
        tastes[0] += sweet;
        tastes[1] += sour;
        tastes[2] += salty;
        tastes[3] += bitter;
        tastes[4] += umami;

        if (character != 0)
        {
            profile[character] += characterLvl;
        }
    }

    void LevelsUpdate()
    {
        //loop through array to get highest and second highest tastelvl
    } 

    void GenerateName()
    {
       //update levels and then assign names 
    }
    
}
