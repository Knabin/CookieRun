using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScene : BaseScene
{
    void Start()
    {
        base.Init();

        SceneType = Define.Scene.LobbyScene; 

        AudioClip clip = GetComponent<AudioSource>().clip;
        Managers.Sound.Play(clip, Define.Sound.Bgm);
    }


    public override void Clear()
    {

    }

    public void StartGame()
    {
        // TODO :
        // something to do
        Managers.Scene.LoadScene(Define.Scene.GameScene);
    }
}
