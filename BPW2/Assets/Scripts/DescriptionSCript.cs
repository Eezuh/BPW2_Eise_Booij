using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DescriptionSCript : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI Character;
    public Image swBar;
    public Image soBar;
    public Image saBar;
    public Image biBar;
    public Image umBar;
    public Image charBar;


    public void ShowIngredient(string ingredient)
    {
        switch (ingredient)
        {
            case "Nolem":
                Name.text = "Nolem Fruit";
                Description.text = "...";
                Character.text = "Citric";
                swBar.fillAmount = 0.25f;
                soBar.fillAmount = 0.5f;
                saBar.fillAmount = 0f;
                biBar.fillAmount = 0f;
                umBar.fillAmount = 0f;
                charBar.fillAmount = 0.33f;
                break;

            case "BloodLiquor":
                Name.text = "Dragon Blood Liquor";
                Description.text = "...";
                Character.text = "Bloody";
                swBar.fillAmount = 0f;
                soBar.fillAmount = 0.5f;
                saBar.fillAmount = 0f;
                biBar.fillAmount = 0.5f;
                umBar.fillAmount = 0f;
                charBar.fillAmount = 0.66f;
                break;

            case "SnakeScale":
                Name.text = "Crimson Serpent Scale";
                Description.text = "...";
                Character.text = "Bloody";
                swBar.fillAmount = 0.25f;
                soBar.fillAmount = 0f;
                saBar.fillAmount = 0f;
                biBar.fillAmount = 0.25f;
                umBar.fillAmount = 0.25f;
                charBar.fillAmount = 0.33f;
                break;
        }
    }

    void SetFillAmount()
    {
       // Bar.fillAmount = value;
    }

}
