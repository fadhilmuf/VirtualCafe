using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewScene : MonoBehaviour
{
    public int Scene;
    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
