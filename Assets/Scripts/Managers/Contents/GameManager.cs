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

    // TODO :
    // 여기서 게임 시작할 때
    // Change를 해 주면서
    // 그 쿠키에 해당하는 Component를 동적으로 붙여 주고
    // 이거를 로딩할 때 진행해 주면 될 것 같음!

}
