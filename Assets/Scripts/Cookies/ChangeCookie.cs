using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCookie : MonoBehaviour
{
    [System.Serializable]
    public class SerializeDicCookie : CustomDic.SerializableDictionary<Define.CookieType, AnimatorOverrideController>
    {
    }

    public SerializeDicCookie CookieAnimators;
}
