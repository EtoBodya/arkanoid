using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rg;
    public float power;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        power = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        rg.AddForce(new Vector3(0.5f, 1.2f)* power* Time.deltaTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
