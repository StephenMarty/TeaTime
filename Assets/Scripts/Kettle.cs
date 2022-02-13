using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettle : ClickObject
{
    public List<string> Ingredients = new List<string>();
    public int ID;

    private void Start()
    {
        
    }

    public void AddIngredient(string Type)
    {
        Ingredients.Add(Type);
    }

    public override void FireMouseEvent()
    {
        transform.parent.GetComponent<KettleManager>().SetArrow(gameObject, ID);
    }
}
