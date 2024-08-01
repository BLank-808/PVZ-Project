using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Zstats : MonoBehaviour
{

    public float HP;
    private Animator animator;
    private Rigidbody2D Rigidbody2D;
    public float Speed;
    public GameObject self;
    public GameObject Parent;
    private EnemySpawn EnemySpawn;
    public GameObject EnemyTracker;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponentInParent<Animator>();
        EnemyTracker=GameObject.Find("Zombie Spawns").gameObject;
    EnemySpawn = EnemyTracker.GetComponent<EnemySpawn>();
    }


        // Update is called once per frame
        void Update()
        {
            if (animator.GetBool("Walk"))
            {
                Rigidbody2D.velocity = new Vector2(Speed * -1, Rigidbody2D.velocity.y);
            } else { Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y); }
            if (HP <= 0) { Destroy(self);EnemySpawn.Enemykilled += 1; EnemySpawn.EnemyCount -= 1; }
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Attack", true);
        }
    public void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("Walk", true);
        animator.SetBool("Attack", false);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
        {if (collision.tag == "Plant")
        {
            HP = HP - 10;
        }
        }

    public void Spawn(Transform spawnp)
    {
        Instantiate<GameObject>(Parent, spawnp);
    }
}
