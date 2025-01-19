using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPanel : MonoBehaviour
{
    public bool isVisible;

    // Start is called before the first frame update
    void Start()
    {
        isVisible = true;
        Invoke("PanelDestroy", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PanelDestroy()
    {
        isVisible = false;
        Destroy(this.gameObject);
    }
}
