using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float Speed=default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, y) * Speed, Space.Self);
    }
}
