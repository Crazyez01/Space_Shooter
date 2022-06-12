using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D meurB;
    // Start is called before the first frame update
    void Start()
    {
        meurB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
