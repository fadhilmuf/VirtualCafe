using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnButton : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(SpawnObject);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void SpawnObject() 
    {
        Vector3 spawnPosition = (point.transform.position);
        GameObject newObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

}
