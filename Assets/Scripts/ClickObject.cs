using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public float Cooldown = 0.5f;
    private float LastClick = 0f;

    private void OnMouseDown()
    {
        if (LastClick == 0f || Time.time >= LastClick + Cooldown)
        {
            LastClick = Time.time;
            FireMouseEvent();
        }
    }

    public virtual void FireMouseEvent()
    {

    }
}
