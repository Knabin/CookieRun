using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    void Start()
    {
        base.Init();

        SceneType = Define.Scene.GameScene; 
    }


    public override void Clear()
    {

    }
}
