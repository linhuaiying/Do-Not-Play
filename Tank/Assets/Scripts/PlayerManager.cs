using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    //属性值
    public int playerScore = 0;
    public bool isDead;
    public bool isDefeat;


    //引用
    public GameObject player1;
    public GameObject player2;//从born修改成player1和player2
    public Text playerScoreText;
    public Text PlayerLifeValueText1;
    public Text PlayerLifeValueText2;
    public GameObject isDefeatUI;
    public GameObject mainUI;
    public int play1LifeValue=3;
    public int play2LifeValue=3;
    public static GameObject GameManager;//不可销毁的单例
    public int KillEenemyNumber = 0;//杀敌数
    public int Level = 1;//关卡
    //单例
    private static PlayerManager instance;

    public static PlayerManager Instance()
    {
        if(instance==null)
        {
            GameManager = new GameObject("instance");
            instance = GameManager.AddComponent(typeof(PlayerManager)) as PlayerManager;
            DontDestroyOnLoad(GameManager);
        }
        return instance;
    }



    // Use this for initialization
    void Start () {
        play1LifeValue = 3;
        Debug.Log(play1LifeValue);
	}
	
	// Update is called once per frame
	void Update () {
        if (isDefeat)
        {
            isDefeatUI.SetActive(true);
            //重新开始本关


            return;
        }
        if(KillEenemyNumber==20)
        {
            //下一关


            KillEenemyNumber -= 20;
        }
        playerScoreText.text = playerScore.ToString();
        PlayerLifeValueText1.text = play1LifeValue.ToString();//角色1生命栏
      //  PlayerLifeValueText2.text = play2LifeValue.ToString();//角色2生命栏
	}

    /*
    private void ReturnToTheMainMenu()
    {
        mainUI.SetActive(true);
    }
    */
}
