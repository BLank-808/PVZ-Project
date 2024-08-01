using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantspawn : MonoBehaviour
{
    public bool Open = true;
    public  Transform Transform;
    private PlantSpawner PlantSpawner;
    // Update is called once per frame
    private void Start()
    {
        Transform = GetComponent<Transform>();
        PlantSpawner= GameObject.Find("Spawn Check").GetComponent<PlantSpawner>();
    }

    private void OnMouseUpAsButton()
    {
        if (Open & PlantSpawner.On) { Open = false; PlantSpawner.On = false; PlantSpawner.Spawn(Transform); }
    }
    public void freeUP()
    {
        Open = true;
    }
}
