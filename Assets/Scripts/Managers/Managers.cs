using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers staticInstance;
    static Managers Instance { get { Init(); return staticInstance; } }

    // TODO :
    // Manager
    SceneManagerEx _scene = new SceneManagerEx();

    public static SceneManagerEx Scene { get { return Instance._scene; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    static void Init()
    {
        if(staticInstance == null)
        {
            GameObject go = GameObject.Find("@Managers");

            // Scene에 GameObject인 @Managers가 없다면 새로 추가함
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            staticInstance = go.GetComponent<Managers>();

            // TODO :
            // 각 Manager들의 Init을 호출한다.
        }
    }

    public static void Clear()
    {
        Scene.Clear();
    }
}
