using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;
    // Start is called before the first frame update
    void Start()
    {
        if(transitionName == movement.instance.areaTransition)
        {
            movement.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
