using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTracker : MonoBehaviour
{
    public float Sun;
    private float timer = 1f;
    private float coundown = 1f;
    private bool earn = true;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        timer = timer / speed;
        coundown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (!earn)
        {
            coundown -= Time.deltaTime;
            if (coundown < 0) { earn = true; coundown = timer; }
        }
        else { Sun += 10; earn = false; }
    }
}
