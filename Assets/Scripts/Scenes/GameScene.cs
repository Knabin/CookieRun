using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    void Start()
    {
        base.Init();

        SceneType = Define.Scene.GameScene; 

        AudioClip clip = GetComponent<AudioSource>().clip;
        Managers.Sound.Play(clip);

        // TODO :
        // 맵 로드가 끝나면 UI 끄고, 게임 시작 처리
        // 시작 전까지는 게임 속도를 0으로 둔다
    }


    public override void Clear()
    {
        Debug.Log("GameScene Clear!");
    }
}
