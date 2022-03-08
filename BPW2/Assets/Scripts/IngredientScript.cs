using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientScript : MainScript
{
    public int sweetness;
    public int sourness;
    public int saltiness;
    public int bitterness;
    public int umaminess;
    public int character;
    public int characterlvl;

    public void SendIngredients()
    {
        addIngredient(sweetness, sourness, saltiness, bitterness, umaminess, character, characterlvl);
    }
}
