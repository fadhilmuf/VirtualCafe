using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex : MonoBehaviour
{
    public Open op;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Canvas);
    }

    private void Canvas()
    {
        op.cvs.enabled = false;
    }
}
