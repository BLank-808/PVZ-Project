using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public EnemySpawn EnemySpawn;
    public GameObject EnemyTracker;
    private void Start()
    {
        EnemyTracker = GameObject.Find("Zombie Spawns").gameObject;
        EnemySpawn = EnemyTracker.GetComponent<EnemySpawn>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Lose");
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemySpawn.Enemykilled==25)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
