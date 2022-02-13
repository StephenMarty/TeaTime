using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Workspace : MonoBehaviour
{
    private Transform Shutter;
    private Transform Table;
    private bool IsOpen;

    private bool DoTransition;

    void Start()
    {
        Shutter = transform.GetChild(0);
        Table = transform.GetChild(1);
        IsOpen = false; 

        //TransitionStep = 0f;

        if (SceneManager.GetActiveScene().name != "Title")
        {
            DoTransition = true; //Settig this to true. That way it opens up when you hit Game Over!
            StartCoroutine(DelayOpen()); //After a second or two; of course!
        }
        else
        {
            DoTransition = false;
        }
    }

    void Update()
    {
        if (DoTransition)
        {
            float Speed = Time.unscaledDeltaTime * 19.2f;

            Shutter.position += new Vector3(0, (IsOpen ? 1 : -1) * Speed * 0.85f, 0);
            Table.position += new Vector3(0, (IsOpen ? -1 : 1) * Speed, 0);

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

    //Checks if workspace is closed without accessing private variables. also sets IsOpen to false as needed.
    public bool Closed(){
        IsOpen = false;
        return Table.position.y == 0.3f;
    }


    IEnumerator DelayOpen()
    {
        yield return new WaitForSeconds(1.5f);
        Toggle();
    }

}   