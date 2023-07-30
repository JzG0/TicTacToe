using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Manager
{
    protected static GameManager instance;
    int player;
    int PC;
    [SerializeField] private GameObject chooseCharacter;
    [Header("Button")]
    [SerializeField] private Button titleStartBtn;
    [SerializeField] private Button selectStartBtn;
    [SerializeField] private Button btnO;
    [SerializeField] private Button btnX;
    [Header("Image")]
    [SerializeField] private Image imageO;
    [SerializeField] private Image imageX;
    public List<int> list = new List<int>();
    private void Awake()
    {
        Initialize();
    }
    public override void Initialize()
    {
        this.Singleton(ref instance);
        base.Initialize();
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
