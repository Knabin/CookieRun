using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScene : BaseScene
{
    [SerializeField]
    GameObject TitleImage;
    [SerializeField]
    GameObject LoadingArea;

    private Slider LoadingSlider;

    void Start()
    {
        base.Init();

        SceneType = Define.Scene.LoadingScene;
        LoadingSlider = LoadingArea.GetComponentInChildren<Slider>();
        
        AudioClip clip = GetComponent<AudioSource>().clip;
        Managers.Sound.Play(clip);

        LeanTween.imageColor(TitleImage.GetComponent<RectTransform>(), new Color(1, 1, 1, 1), 1f);
        LeanTween.scale(TitleImage, new Vector3(1.0f, 1.0f, 1.0f), 3.5f).setEase(LeanTweenType.easeOutBounce);

        StartCoroutine(SetLoadingObjectActive());
    }

    private void Update()
    {
        // some code
    }

    public override void Clear()
    {
        Debug.Log("LoadingScene Clear!");
    }

    IEnumerator SetLoadingObjectActive() {
        yield return new WaitForSeconds(4f);
        LoadingArea.SetActive(true);
        StartCoroutine(StartLoading());
    }

    IEnumerator StartLoading() {
        // TODO :
        // Something to do 
        // ex) 서버 연결, 애셋 번들 다운 등
        yield return new WaitForSeconds(4f);
        StartCoroutine(TestFunction());
    }

    IEnumerator TestFunction() {
        // FIXME : 
        // 슬라이더 테스트 코드

        while (true) {
            SetLoadingSlider(0.1f);
            yield return new WaitForSeconds(0.5f);

            if (LoadingSlider.value >= 1) break;
        }
        Managers.Scene.LoadScene(Define.Scene.LobbyScene);
    }

    void SetLoadingSlider(float value) {
        if (LoadingSlider) {
            LoadingSlider.value += value;
        }
    }
}
