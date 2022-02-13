using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : ClickObject
{
    public GameObject Workspace;
    public override void FireMouseEvent()
    {
        Workspace.GetComponent<Workspace>().Toggle();
    }
}
