using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum State
{
    StartGame, //ī��Ʈ�ٿ�, ���� ���� �Ұ���, �ð� �帣�� ����
    InGame, //���� ���� ����, �ð� �帧
    Setting //���� ���� �Ұ���, �ð� �帣�� ����
}

public class GameManager : Manager
{
    protected static GameManager instance;
    int player;
    int PC;

    [Header("ī��Ʈ�ٿ�")]
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
                //ī��Ʈ�ٿ� ����, ���� ���� �Ұ���, �ΰ��� �ð� �帣�� ����
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
                //���� ���� �Ұ���, �ð� �帣�� ����
                break;
            case State.InGame:
                //���� ���� ����, �ð� �帧
                break;
        }
    }
    private void InGameMode()
    {
        //settingâ ����
        //�ð� �̾ �帣�� �ϱ�
        
    }
    private void ClearGameMode()
    {
        //settingâ ����
        //�ð� 0���� �ʱ�ȭ �ϱ�
        //���� �̹��� �ʱ�ȭ �ϱ�
    }
    private void GameRule()
    {
        #region ���� ����
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
        #region ���� ����
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
        #region �밢�� ����
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
