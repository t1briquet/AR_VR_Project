using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ToggleWinMenu();
        
    }
    public void ToggleWinMenu()
    {
         gameObject.SetActive(true);   
    }
}
