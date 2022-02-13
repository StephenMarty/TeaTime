using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Vector3 Target;
    public bool DoMove;

    void Start()
    {
        DoMove = false;

        ToCounter();
    }

    void Update()
    {
        if (DoMove)
        {
            float speed = 1.5f;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target, step);

            if (Vector3.Distance(transform.position, Target) < 0.001f)
            {
                transform.position = Target;
                DoMove = false;
            }
        }
    }

    public void ToCounter()
    {
        Target = new Vector3(4.1f, -1.9f, 0f);
        DoMove = true;
    }

    public void ToSeat()
    {
        
    }

    public void Moodle()
    {

    }
}
