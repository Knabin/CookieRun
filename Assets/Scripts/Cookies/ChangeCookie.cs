using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCookie : MonoBehaviour
{
    [System.Serializable]
    public class SerializeDicEntity : CustomDic.SerializableDictionary<Define.CookieType, SerializeDicSub>
    {
    }

    [System.Serializable]
    public class SerializeDicSub : CustomDic.SerializableDictionary<BaseCookie, AnimatorOverrideController>
    {

    }

    public SerializeDicEntity Test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
