using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocktailParts : MonoBehaviour
{
    public GameObject Glass;
    public GameObject Fluid;
    public GameObject Dec1;
    public GameObject Dec2;

    private void Start()
    {
        this.Glass.SetActive(false); //does 'this' work in this way?
        this.Fluid.SetActive(false);
        this.Dec1.SetActive(false);
        this.Dec2.SetActive(false);
    }
    void AddItem(GameObject item)
    {
        //based on another function that keeps track of the items to add while mixing

        item.SetActive(true);
    }
}
