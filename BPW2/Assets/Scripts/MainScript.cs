using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject InGameCocktail; //maybe this needs to be a seperate script
   
    int[] tastes = new int[5];
    int[] profile = new int[5]; //becomes more once you add more profiles !!! 0 is nothing !!!

    int floralLvl;
    int metallicLvl;
    int fruityLvl;
    //etc

    int color; //and other visual characteristics

    string MainTasteName;
    string SecondaryTasteName;
    string CharacterProfileName;
    string finalname;

    private void Start()
    {
        int i;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        for (i = 1; i < tastes.Length; i++) //check if these are really necessary
        {
            tastes[i] = 0;
        }

        for (i = 1; i < profile.Length; i++)
        {
            tastes[i] = 0;
        }
    }

    public void addIngredient(int sweet, int sour, int salty, int bitter, int umami, int character, int characterLvl)
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

    public void LevelsUpdate() //doesnt work correctly yet :(
    {
        //if levels are the same, get a mix !!!! w
        
        int first = int.MinValue;
        int firstValue = 0;
        int second = int.MinValue;
        int secondValue = 0;
        int mainCharacter = profile[0];
        int i;

        for (i = 1; i < tastes.Length; i++) //these return the index where the highest value is in
        {
            if (tastes[i] >= firstValue)
            {
                secondValue = firstValue;
                firstValue = tastes[i];
                second = first;
                first = i;
            }
            else if (tastes[i] > secondValue)
            {
                secondValue = tastes[i];
                second = i;
            }
        }
        for (i = 1; i < profile.Length; i++)
        {
            if (profile[i] > profile[mainCharacter])
            {
                mainCharacter = i;
            }
        }

        Debug.Log("main ingredient is:" + first + "with level" + tastes[first]); //returns 1 with level 0 always

        GenerateName(first, second, mainCharacter);
    }

    void GenerateName(int index1, int index2, int index3)
    {
     switch (index2)
        {
            case 0:
                if(tastes[index2] > 4)
                {
                    SecondaryTasteName = "Sugarbomb";
                }
                else
                {
                    SecondaryTasteName = "Sweet";
                }
            break;


            case 1:
                if (tastes[index2] > 4)
                {
                    SecondaryTasteName = "Acidic";
                }
                else
                {
                    SecondaryTasteName = "Sour";
                }
                break;

            case 2:
                if (tastes[index2] > 4)
                {
                    SecondaryTasteName = "Seawater"; //not an adjective
                }
                else
                {
                    SecondaryTasteName = "Salty"; //meh
                }
                break;

            case 3:
                if (tastes[index2] > 4)
                {
                    SecondaryTasteName = "Pungent";
                }
                else
                {
                    SecondaryTasteName = "Bitter"; //???
                }
                break;

            case 4:
                if (tastes[index2] > 4)
                {
                    SecondaryTasteName = "Starchy";
                }
                else
                {
                    SecondaryTasteName = "Savoury"; //??? meaty, dry etc
                }
                break;
        }

        switch (index3)
        {
            case 0:
                if (tastes[index3] > 4)
                {
                    CharacterProfileName = "";
                }
                break;


            case 1:
                if (tastes[index3] > 4)
                {
                    CharacterProfileName = "Metallic";
                }
                break;

            case 2:
                if (tastes[index3] > 4)
                {
                    CharacterProfileName = "Fruity";
                }
                break;

            case 3:
                if (tastes[index3] > 4)
                {
                    CharacterProfileName = "Bloody";
                }
                break;

            case 4:
                if (tastes[index3] > 4)
                {
                    CharacterProfileName = "...";
                }
                break;
        }

        switch (index1)
        {
            case 0:
                if (tastes[index1] > 4)
                {
                    SecondaryTasteName = "Sugarbomb";
                }
                else
                {
                    SecondaryTasteName = "Lemonade";
                }
                break;


            case 1:
                if (tastes[index1] > 4)
                {
                    MainTasteName = "Acid";
                }
                else
                {
                    MainTasteName = "Juice";
                }
                break;

            case 2:
                if (tastes[index1] > 4)
                {
                    MainTasteName = "Seawater";
                }
                else
                {
                    MainTasteName = "..."; //???
                }
                break;

            case 3:
                if (tastes[index1] > 4)
                {
                    MainTasteName = "...";
                }
                else
                {
                    MainTasteName = "..."; //???
                }
                break;

            case 4:
                if (tastes[index1] > 4)
                {
                    MainTasteName = "...";
                }
                else
                {
                    MainTasteName = "Shake"; //??? meaty, dry etc
                }
                break;
        }
        finalname = SecondaryTasteName + CharacterProfileName + MainTasteName;
        Debug.Log(finalname);
    }
    
}
