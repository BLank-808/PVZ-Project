using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float timer = 1f;
    private float coundown = 1f;
    [SerializeField] private Transform[] Lanes;
    private bool CanS = true;
    private Zstats Zstats;
    public GameObject Zombie;
    private Transform Transform;
    public float EnemyCount = 0;
    public float Enemykilled=0;
    // Start is called before the first frame update
    void Start()
    {
        coundown = timer;
        Zstats= Zombie.GetComponentInChildren<Zstats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!CanS)
        {
            if (EnemyCount <= 10) { 
            coundown -= Time.deltaTime;
                if (coundown < 0) { CanS = true; coundown = timer; }
            }
        }
        else { Transform = Lanes[Random.Range(0, Lanes.Length - 1)]; ; CanS = false; Zstats.Spawn(Transform); EnemyCount += 1;}

    }
}
