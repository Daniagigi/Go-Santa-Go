using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panel : MonoBehaviour
{
    public GameObject panel1;
    public TextMeshProUGUI music;
    public TextMeshProUGUI sound;
    public float max;
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setting()
    {
        panel1.SetActive(true);
    }
    public void slide(float value)
    {
        int localvalue = (int)(value * max);
        music.text = localvalue.ToString();
    }
    public void slideS(float value)
    {
        int localvalue = (int)(value * max);
        sound.text = localvalue.ToString();
    }
}
