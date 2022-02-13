using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KettleManager : MonoBehaviour
{
    public Kettle Kettle1;
    public Kettle Kettle2;
    public GameObject Arrow;

    public int ActiveKettle = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetArrow(GameObject Kettle, int ID)
    {
        Arrow.GetComponent<SpriteRenderer>().enabled = true;
        Arrow.transform.position = Kettle.transform.position + new Vector3(-0.5f, 2.2f, 0f);
        ActiveKettle = ID;
    }

    public void AddIngredient(string Type)
    {
        if (ActiveKettle == 1)
        {
            Kettle1.AddIngredient(Type);
        }
        else
        {
            Kettle2.AddIngredient(Type);
        }
    }
}
