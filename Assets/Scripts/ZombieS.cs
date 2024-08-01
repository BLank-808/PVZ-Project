using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieS : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;
    public float Speed;
    private bool canW = true;
    private Rigidbody2D Rigidbody2D;
    public float HP;

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        Rigidbody2D= GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (canW) {Rigidbody2D.velocity=new Vector2 (Speed *1, Rigidbody2D.velocity.y); }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canW = false;
        animator.SetBool("Walk",false);
        animator.SetBool("Attack", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canW = true;
        animator.SetBool("Walk", true);
        animator.SetBool("Attack", false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP -= 10;
    }
}
