using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject InGameCocktail; //do you need this one?
    public GameObject Customer;
    private string CocktailGlass;

    public GameObject Longdrink;
    public GameObject bowl;
    public GameObject cone;
    public GameObject tumbler; 
    public GameObject goblet;

    public ProgressBar sweet;
    public ProgressBar sour;
    public ProgressBar salty;
    public ProgressBar bitter;
    public ProgressBar umami;
    public ProgressBar character;

    public string CharacterName;

    int[] tastes = new int[5];
    int[] profile = new int[6]; //becomes more once you add more profiles !!! 0 is nothing !!!

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

        CharacterName = "None";
    }

    private void Updatebars()
    {
        sweet.CurrentValueUpdate(tastes[0]);
        sour.CurrentValueUpdate(tastes[1]);
        salty.CurrentValueUpdate(tastes[2]);
        bitter.CurrentValueUpdate(tastes[3]);
        umami.CurrentValueUpdate(tastes[4]);
        //character.CurrentValueUpdate(profile[character]); you need a specific character (0, 1 , 2)
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

        Updatebars();
        Debug.Log(tastes[0] + "and" + tastes[1] + "and" + tastes[2] + "and" + tastes[3] + "and" + tastes[4]);
    }

    public void LevelsUpdate() //doesnt work correctly yet :(
    {   
        int first = 0;
        int firstValue = 0;
        int second = int.MinValue;
        int secondValue = 0;
        int mainCharacter = profile[0];
        int i;

        for (i = 0; i < tastes.Length; i++) //these return the index where the highest value is in
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
        for (i = 0; i < profile.Length; i++)
        {
            if (profile[i] > profile[mainCharacter])
            {
                mainCharacter = i;
            }
        }

        Debug.Log("main ingredient is:" + first + "with level" + firstValue); 
        Debug.Log("second ingredient is:" + second + "with level" + secondValue);

        GenerateName(first, second, mainCharacter);
        DisplayCocktail(first);
        Customer.GetComponent<OrderScript>().CheckOrder(first, firstValue, second, secondValue, mainCharacter);

    }

    void DisplayCocktail(int mainIngredient)
    {
        switch (mainIngredient)
        {
            case 0:
                Longdrink.SetActive(true);
            break;

            case 1:
                bowl.SetActive(true);
                break;

            case 2:
                cone.SetActive(true);
                break;
            case 3:
                tumbler.SetActive(true);
                break;
            case 4:
                goblet.SetActive(true);
                break;
        }
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
            case 0: //nothing
                if (tastes[index3] > 2) 
                {
                    CharacterProfileName = "";
                }
                break;


            case 1:
                if (tastes[index3] > 2)
                {
                    CharacterProfileName = "Metallic";
                }
                break;

            case 2:
                if (tastes[index3] > 2)
                {
                    CharacterProfileName = "Citric";
                }
                break;

            case 3:
                if (tastes[index3] > 2)
                {
                    CharacterProfileName = "Bloody";
                }
                break;

            case 4:
                if (tastes[index3] > 2)
                {
                    CharacterProfileName = "Sea-";
                }
                break;

            case 5:
                if (tastes[index3] > 2)
                {
                    CharacterProfileName = "Floral";
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
