using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public float Cooldown = 0.5f;
    private float LastClick = 0f;
    private GameObject Manager;

    private void Start()
    {
        Manager = GameObject.Find("GameManager");
    }

    private void OnMouseDown()
    {
        if (Manager.GetComponent<Manager>().ControlsEnabled)
        {
            if (LastClick == 0f || Time.time >= LastClick + Cooldown)
            {
                LastClick = Time.time;
                FireMouseEvent();
            }
        }
    }

    public virtual void FireMouseEvent()
    {

    }
}
