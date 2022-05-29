using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Result : UI_Base
{
    enum Texts
    {
        ResultText,
        ScoreText,
    }

    enum Buttons
    {
        OkBtn,
    }

    public override void Init()
    {
        Bind<Text>(typeof(Texts));
        Bind<Button>(typeof(Buttons));

        BindEvent(Get<Button>((int)Buttons.OkBtn).gameObject, OnButtonPointerDown_Ok, Define.UIEvent.PointerDown);
    }

    void LateUpdate()
    {
        SetUI();
    }

    void SetUI()
    {
        // TODO :
        // 점수 받아와서 세팅
        // 코인 세팅
    }

    public void OnButtonPointerDown_Ok(PointerEventData data)
    {
        // TODO :
        // 닫고 점수를 서버로 전송
        // 씬 이동
    }
}
