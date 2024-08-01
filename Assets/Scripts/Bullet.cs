using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //Movement Controls 
    private Rigidbody2D _rigidbody2D; //The rigidbody that will move the bullet 
    public float speed = 2;           //Speed at which the bullet moves 

    //Flag and Timer 
    public float deathTime = 1.5f;   //How long before the bullet dies 
    public bool playerBullet = true; //Is the bullet used by player or enemy 

    //==================================================================================================================
    // Base Method  
    //==================================================================================================================

    //Checks who is shooting the bullet and set up the bullet settings 
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity =  new Vector2(speed * 1, _rigidbody2D.velocity.y);
        StartCoroutine(Death());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }
}
