using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene : BaseScene
{
    void Start()
    {
        base.Init();

        SceneType = Define.Scene.LoadingScene;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Managers.Scene.LoadScene(Define.Scene.LobbyScene);
        }
    }

    public override void Clear()
    {
        Debug.Log("LoadingScene Clear!");
    }
}
