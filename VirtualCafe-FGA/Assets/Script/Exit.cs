using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string areaToLoad;
    public string areaTransition;
    public AreaEntrance area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);
            movement.instance.areaTransition = areaTransition;
        }
    }
}
