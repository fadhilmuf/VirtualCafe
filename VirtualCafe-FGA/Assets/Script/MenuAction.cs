using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAction : MonoBehaviour
{
    public GameObject panel, leave, cam;
    public GameObject avatar, emoticon;
    public Transform[] spawn;
    public InputField txtInput;


    private GameObject player, react;


    // Start is called before the first frame update
    void Start()
    {
        leave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                player.transform.position = hit.point;
            }
        }
    }

    public void PindahScene(string nama)
    {
        SceneManager.LoadScene(nama);
    }

    public void JoinRoom()
    {
        panel.SetActive(false);
        leave.SetActive(true);
        cam.SetActive(false);

        int i = Random.Range(0, spawn.Length);
        player = Instantiate(avatar, spawn[i].position, Quaternion.identity);

        GameObject avatarName = GameObject.Find("LblName");
        avatarName.GetComponent<TextMeshPro>().text = txtInput.text;
    }

    public void ShowPanel()
    {
        Destroy(player);

        panel.SetActive(true);
        leave.SetActive(false);
        cam.SetActive(true);
    }

    public void React()
    { 
        react = Instantiate(emoticon, player.transform.position + new Vector3(0, 0, 1), Quaternion.identity);

        StartCoroutine(RemoveEmoticon());
    }

    IEnumerator RemoveEmoticon()
    {
        yield return new WaitForSeconds(2);
        Destroy(react);
    }
}
