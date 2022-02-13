using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettle : MonoBehaviour
{
    private List<string> Ingredients = new List<string>();

    private void Start()
    {
        
    }

    public void AddIngredient(string Type)
    {
        Ingredients.Add(Type);
    }
}
