using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start : UI_Base
{
    enum Objects
    {
        StartObject,
    }

    enum Images
    {
        Cookie,
    }

    enum Texts
    {
        BalloonText,
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(Objects));
        Bind<Image>(typeof(Images));
        Bind<Text>(typeof(Texts));

        // TODO :
        // 현재 선택한 쿠키로 이미지, 텍스트 변경
    }
}
