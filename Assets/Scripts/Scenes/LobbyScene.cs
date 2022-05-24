using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScene : BaseScene
{
    void Start()
    {
        base.Init();

        SceneType = Define.Scene.LobbyScene; 
    }


    public override void Clear()
    {

    }
}
