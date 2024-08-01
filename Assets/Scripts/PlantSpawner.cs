using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

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
    public GameObject Text;
    public TextMeshProUGUI meshPro;    // Start is called before the first frame update
    void Start()
    {
    PeashoterStats=Peashooter.GetComponentInChildren<Pstats>();
    SunflowerStats = Sunflower.GetComponentInChildren<Pstats>();
    SunTracker = GameObject.Find("Tracker").GetComponent<SunTracker>();
   meshPro=Text.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        meshPro.SetText(SunTracker.Sun.ToString());
    }
    public void PeaS() { if ((SunTracker.Sun - 100) >= 0) { SunTracker.Sun = SunTracker.Sun - 100; On = true; Pea = true; Sun = false; } }

    public void SunS() { if ((SunTracker.Sun - 50) >= 0) { SunTracker.Sun = SunTracker.Sun - 50; On = true; Sun = true; Pea = false; } }

    public void Spawn(Transform A) { if (Pea) { PeashoterStats.Spawn(A); }
        if (Sun) { SunflowerStats.Spawn(A); }
    }
}
