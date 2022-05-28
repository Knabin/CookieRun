using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Play : UI_Base
{
    enum Sliders
    {
        HPPanel,
    }

    enum Texts
    {
        CoinText,
        ScoreText,
    }

    enum Objects
    {
        HeartOver,
        Pause,
    }

    enum Images
    {
        SlideButton,
        JumpButton,
        PauseButton
    }

    public override void Init()
    {
        Bind<Slider>(typeof(Sliders));
        Bind<Text>(typeof(Texts));
        Bind<GameObject>(typeof(Objects));
        Bind<Image>(typeof(Images));
        
        Get<GameObject>((int)Objects.Pause).SetActive(false);
        Get<GameObject>((int)Objects.HeartOver).SetActive(false);

        BindEvent(Get<Image>((int)Images.SlideButton).gameObject, OnButtonPointerDown_Slide, Define.UIEvent.PointerDown);
        BindEvent(Get<Image>((int)Images.SlideButton).gameObject, OnButtonPointerUp_Slide, Define.UIEvent.PointerUp);

        BindEvent(Get<Image>((int)Images.JumpButton).gameObject, OnButtonClicked_Jump);

        BindEvent(Get<Image>((int)Images.PauseButton).gameObject, OnButtonClicked_Pause);
    }

    void LateUpdate()
    {
        SetUI();
    }

    void SetUI()
    {
        // TODO :
        // 체력 받아와서 체력 슬라이더 세팅
        // 점수 세팅
        // 코인 세팅
    }

    public void OnButtonPointerDown_Slide(PointerEventData data)
    {
        // TODO :
        // 슬라이드 시작
    }
    public void OnButtonPointerUp_Slide(PointerEventData data)
    {
        // TODO :
        // 슬라이드 해제
    }

    public void OnButtonClicked_Jump(PointerEventData data)
    {
        // TODO :
        // 점프임을 알림
    }

    public void OnButtonClicked_Pause(PointerEventData data)
    {
        Get<GameObject>((int)Objects.Pause).SetActive(true);
    }
}
