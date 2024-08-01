using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    public bool On = false;
    public bool Pea = false;
    public bool Sun = false;
    public GameObject Peashooter;
    public GameObject Sunflower;
    public Pstats SunflowerStats;
    public  Pstats PeashoterStats;
    public SunTracker SunTracker;
    // Start is called before the first frame update
    void Start()
    {
    PeashoterStats=Peashooter.GetComponentInChildren<Pstats>();
    SunflowerStats = Sunflower.GetComponentInChildren<Pstats>();
    SunTracker = GameObject.Find("Tracker").GetComponent<SunTracker>();
    }

    public void ON()
    {
       On = true;
    }
    public void PeaS() { if (SunTracker.Sun - 100 >= 0) { Pea = true; Sun = false; } }

    public void SunS() { if (SunTracker.Sun - 50 >= 0){ Sun = true; Pea = false; } }

    public void Spawn(Transform A) { if (Pea) { PeashoterStats.Spawn(A); }
        if (Sun) { SunflowerStats.Spawn(A); }
    }
}
