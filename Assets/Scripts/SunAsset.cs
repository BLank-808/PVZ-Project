using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunAsset : MonoBehaviour
{
    public SunTracker SunTracker;
    public Rigidbody2D Rigidbody;
    public float speed = 1;
    public float deathTime = 1.5f;   //How long before the bullet dies 
    // Start is called before the first frame update
    private void Start()
    {
        SunTracker = GameObject.Find("Tracker").GetComponent<SunTracker>();
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.velocity = new Vector2(speed * 1, Rigidbody.velocity.y);
        StartCoroutine(Death());
    }
    private void OnMouseEnter()
    {
        SunTracker.Sun += 20;
        Destroy(gameObject);
    }
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }
}
