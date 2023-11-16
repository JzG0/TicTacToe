using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum State
{
    StartGame, //카운트다운, 게임 진행 불가능, 시간 흐르지 않음
    InGame, //게임 진행 가능, 시간 흐름
    Setting //게임 진행 불가능, 시간 흐르지 않음
}

public class GameManager : Manager
{
    protected static GameManager instance;
    int player;
    int PC;

    [Header("카운트다운")]
    [SerializeField] private Image countDown;
    [SerializeField] private GameObject countDownPanel;
    [SerializeField] private Animator anim;
    private float time = 3;
    private bool isTimerUpdate = false;

    public List<int> list = new List<int>();

    [SerializeField] private State state;

    private void Awake()
    {
        Initialize();
    }
    public override void Initialize()
    {
        this.Singleton(ref instance);
        base.Initialize();
    }

    private void Start()
    {
        isTimerUpdate = true;
        countDownPanel.SetActive(true);
    }

    private void Update()
    {
        Debug.Log(time);
        switch (state)
        {
            case State.StartGame:
                //카운트다운 진행, 게임 진행 불가능, 인게임 시간 흐르지 않음
                if (isTimerUpdate)
                {
                    anim.SetTrigger("1sec");
                    time -= Time.deltaTime;
                    if (time <= 2)
                    {
                        countDown.sprite = Resources.Load<Sprite>("UI/2");
                        anim.SetTrigger("1sec");
                        if (time <= 1)
                        {
                            countDown.sprite = Resources.Load<Sprite>("UI/1");
                            anim.SetTrigger("1sec");
                            if (time <= 0)
                            {
                                countDownPanel.SetActive(false);
                                state = State.InGame;
                                isTimerUpdate = false;
                            }
                        }
                    }
                }
                break;

                
                
            case State.Setting:
                //게임 진행 불가능, 시간 흐르지 않음
                break;
            case State.InGame:
                //게임 진행 가능, 시간 흐름
                break;
        }
    }
    private void InGameMode()
    {
        //setting창 끄기
        //시간 이어서 흐르게 하기
        
    }
    private void ClearGameMode()
    {
        //setting창 끄기
        //시간 0으로 초기화 하기
        //보드 이미지 초기화 하기
    }
    private void GameRule()
    {
        #region 가로 빙고
        if (list[0] == 0 && list[1] == 0 && list[2] == 0)
        {
            Debug.Log("You Win!");
        }
        if (list[3] == 0 && list[4] == 0 && list[5] == 0)
        {
            Debug.Log("You Win!");
        }
        if (list[6] == 0 && list[7] == 0 && list[8] == 0)
        {
            Debug.Log("You Win!");
        }
        #endregion
        #region 세로 빙고
        if (list[0] == 0 && list[3] == 0 && list[6] == 0)
        {
            Debug.Log("You Win!");
        }
        if (list[1] == 0 && list[4] == 0 && list[7] == 0)
        {
            Debug.Log("You Win!");
        }
        if (list[2] == 0 && list[5] == 0 && list[8] == 0)
        {
            Debug.Log("You Win!");
        }
        #endregion
        #region 대각선 빙고
        if (list[0] == 0 && list[4] == 0 && list[8] == 0)
        {
            Debug.Log("You Win!");
        }
        if (list[2] == 0 && list[4] == 0 && list[6] == 0)
        {
            Debug.Log("You Win!");
        }
        #endregion
    }
}
