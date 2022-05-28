using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCookie : MonoBehaviour
{
    public enum CookieState
    {
        Die,
        Revive,
        Idle,
        Jump,
        Skill,
    }

    // 무적 시간
    public bool isInvincible;
    // 거대화
    public bool isGigantic = false;
    protected int _reviveCount = 0;

    [SerializeField]
    CookieState _state = CookieState.Idle;

    Rigidbody2D _body;
    Animator    _anim;

    float _speed = 1.0f;
    
    
    protected virtual void UpdateDie()
    {
        // TODO :
        // 살아날 수 있으면 살아나고 아니면 죽음
    }

    void UpdateRevive()
    {
        // TODO :
        // 부활 처리
        // 무적
    }

    void UpdateIdle()
    {

    }

    void UpdateJump()
    {

    }

    protected virtual void UpdateSkill()
    {
        // Nothing to do here
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_state)
        {
            case CookieState.Die:
                UpdateDie();
            break;
            case CookieState.Revive:
                UpdateRevive();
            break;
            case CookieState.Idle:
                UpdateIdle();
            break;
            case CookieState.Jump:
                UpdateJump();
            break;
            case CookieState.Skill:
                UpdateSkill();
            break;
        }
    }
}
