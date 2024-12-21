using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class snow : MonoBehaviour
{
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
