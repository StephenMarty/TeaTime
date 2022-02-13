using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workspace : MonoBehaviour
{
    private Transform Shutter;
    private Transform Table;
    private bool IsOpen;

    //private float TransitionStep;
    private bool DoTransition;

    void Start()
    {
        Shutter = transform.GetChild(0);
        Table = transform.GetChild(1);
        IsOpen = false;

        //TransitionStep = 0f;
        DoTransition = false;
    }

    void Update()
    {
        if (DoTransition)
        {
            float Speed = Time.unscaledDeltaTime * 19.2f;

            Shutter.position += new Vector3(0, (IsOpen ? 1 : -1) * Speed * 0.85f, 0);
            Table.position += new Vector3(0, (IsOpen ? -1 : 1) * Speed, 0);

            /*TransitionStep += Time.unscaledDeltaTime;
            if (TransitionStep >= 0.3f)
            {
                DoTransition = false;
                TransitionStep = 0f;
                IsOpen = !IsOpen;
            }*/

            if (!IsOpen && Table.position.y >= 0.3f)
            {
                Table.position = new Vector3(0, 0.3f, 0);
                Shutter.position = new Vector3(0, 6.54f, 0);
                DoTransition = false;
                IsOpen = !IsOpen;
            }
            else if (IsOpen && Table.position.y <= -5.5f)
            {
                Table.position = new Vector3(0, -5.5f, 0);
                Shutter.position = new Vector3(0, 11.5f, 0);
                DoTransition = false;
                IsOpen = !IsOpen;
            }
        }
    }

    public void Toggle()
    {
        DoTransition = true;
    }
}
