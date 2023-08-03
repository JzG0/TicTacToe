using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : Manager
{
    protected static GameManager instance;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI timeUI;

    int player;
    int PC;
    float time;
    int hh;
    int mm;
    int ss;

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

    private void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            time = 0;
            ss++;
            if (ss >= 60)
            {
                ss = 0;
                mm++;
            }
            if(mm >= 60)
            {
                mm = 0;
                hh++;
            }
            timeUI.text = hh.ToString("D2") + " : " + mm.ToString("D2") + " : " + ss.ToString("D2");
        }
        Debug.Log(timeUI.text);
    }

    private void GameRule()
    {
        #region °¡·Î ºù°í
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
        #region ¼¼·Î ºù°í
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
        #region ´ë°¢¼± ºù°í
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
