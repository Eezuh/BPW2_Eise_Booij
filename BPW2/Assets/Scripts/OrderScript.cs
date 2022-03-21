using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderScript : MonoBehaviour
{
    public int MainIngredient;
    public int MainIngredientMaxStrenght;
    public int SecondaryIngredient; //5 is for doesnt matter
    public int SecondaryIngredientMaxStrenght;
    public int Character; //5 is for doesnt matter
    public TextMeshProUGUI OrderText;

    public string order;
    public string success;
    public string fail;

    private bool accepted = true;

    public void StartOrder()
    {
        OrderText.text = order;
    }

    public void CompleteOrder()
    {
        if (accepted == true)
        {
            OrderText.text = success;
        }
        else
        {
            OrderText.text = fail;
        }
        
    }
}
