using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducktest : MonoBehaviour
{
    public Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move);
    }
}
