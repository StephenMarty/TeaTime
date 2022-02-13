using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : ClickObject
{
    public string Type = "";
    public GameObject Kettle;

    private Vector3 OrgPosition;
    private Vector3 KettlePosition;

    private void Start()
    {
        OrgPosition = transform.position;
        KettlePosition = new Vector3(0.3f, 0.1f, 0f);
    }

    private void DoMove()
    {

    }

    public override void FireMouseEvent()
    {
        switch (Type)
        {
            case "Sugar":
                Kettle.GetComponent<KettleManager>().AddIngredient("Sugar");
                break;
            case "Honey":
                Kettle.GetComponent<KettleManager>().AddIngredient("Honey");
                break;
            case "Chamomile":
                Kettle.GetComponent<KettleManager>().AddIngredient("Chamomile");
                break;
            case "Green Tea":
                Kettle.GetComponent<KettleManager>().AddIngredient("Green Tea");
                break;
            case "Black Tea":
                Kettle.GetComponent<KettleManager>().AddIngredient("Black Tea");
                break;
            default:
                Debug.Log("Invalid Type value!");
                break;
        }
    }
}
