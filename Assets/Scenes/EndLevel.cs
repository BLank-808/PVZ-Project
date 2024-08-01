using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

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
        SceneManager.UnloadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
        if (EnemySpawn.Enemykilled==25)
        {
            SceneManager.LoadScene("Win");
            SceneManager.UnloadScene(1);
        }
    }
}
