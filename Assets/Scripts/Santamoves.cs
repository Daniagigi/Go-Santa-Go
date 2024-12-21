using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Santamoves : MonoBehaviour
{
    Vector3 pos;
    float speed = 2;
    public float dist;
    public GameObject newspwn;
    public GameObject fence,cloud;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("newspwn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x += Input.GetAxis("Horizontal");
        pos.z += Input.GetAxis("Vertical");
        pos.y += Input.GetAxis("Jump");
        pos.x = Mathf.Clamp(pos.x, -14.9f, 18.7f);
        pos.z = Mathf.Clamp(pos.z, -22.8f, 30.6f);
        pos.y = Mathf.Clamp(pos.y, 4, 4.4f);
        transform.position = pos;
        dist = Vector3.Distance(transform.position, fence.transform.position);

        if(dist<=16.5)
        {
            cloud.GetComponent<Rigidbody>();
        }

    }
    void spwn()
    {
         Vector2 spwnposition =new Vector2 (Random.Range(-4.6f,-4.6f),4);
        GameObject datatwo = Instantiate(newspwn, spwnposition, Quaternion.identity);
        Destroy(datatwo, 16f);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("nillgift"))
        {
            Debug.Log("zero gift");
        }
        if (collision.gameObject.tag == ("gift"))
        {
            Debug.Log(" Gift collected .game over");
        }
    }
    
}
