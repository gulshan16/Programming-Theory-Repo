using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fast();
    }
    
    protected virtual void Fast()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

