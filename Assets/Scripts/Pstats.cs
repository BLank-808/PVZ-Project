using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pstats : MonoBehaviour
{
    public float HP;
    private Animator animator;
    public float Speed;
    public GameObject self;
    public GameObject Parent;
    public bool CanA=true;
    private float timer = 1f;
    private float coundown = 1f;
    public GameObject preFab;
    public Transform bulletspawn;
    public Plantspawn Plantspawn;
    // Start is called before the first frame update
    void Start()
    {
        timer = timer / Speed;
        coundown = timer;
        animator = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanA == false)
        {
            coundown -= Time.deltaTime;
            if (coundown < 0) { CanA = true; coundown = timer; }
        }
        if (CanA)
        {
            GameObject bullet = Instantiate(preFab, bulletspawn.position, Quaternion.identity);
            CanA = false;

        }
        if (HP <= 0) {Plantspawn.freeUP(); Destroy(self);}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
            HP = HP - 10;
        }
        if (collision.tag== "Respawn")
        {
            Plantspawn=collision.GetComponent<Plantspawn>();
        }
    }

    public void Spawn(Transform spawnp)
    {
        Instantiate<GameObject>(Parent, spawnp);
    }
}
