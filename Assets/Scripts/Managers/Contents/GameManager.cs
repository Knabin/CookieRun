using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager
{
    void Start()
    {
        GameObject jump = GameObject.Find("JumpArea"); 
        if (jump != null)
        {
            jump.GetComponent<Button>().onClick.AddListener(() => OnClick());
        }
    }

    void OnClick()
    {
        Debug.Log("On Click Jump!");
    }

    void OnClick2()
    {
        Debug.Log("On Slide!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
