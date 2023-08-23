using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Move
{
    protected override void Fast()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 50);
    }

    void Update()
    {
        Fast();
    }
}
