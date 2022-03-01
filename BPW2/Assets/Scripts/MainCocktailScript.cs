using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCocktailScript : MonoBehaviour
{
    GameObject InGameCocktail; //maybe this needs to be a seperate script

    int[] tastes = new int[5];
    int[] profile = new int[3]; //becomes more once you add more profiles !!! 0 is nothing !!!

    int floralLvl;
    int metallicLvl;
    int fruityLvl;
    //etc

    int color; //and other visual characteristics

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
    
    void UpdateIngredients()
    {
        //updates color and other visible aspects
    }
    void AddItem()
    {
        //based on another function that keeps track of the items to add while mixing
        //add gameobject to 'InGameCocktail'
        //
    }
}
