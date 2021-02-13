using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//..
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour {

    public Transform posOne;
    public Transform posTwo;
    public static Option instance=null;
    public static GameObject obj;
    public GameObject mainUI;
    public MapCreation Map;
    // Use this for initialization
    void Start () {
        Map = GameObject.Find("MapCreation").GetComponent<MapCreation>();
	}
	 public static Option Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }
    public void Buttom1()
    { 
        transform.position = posOne.position;
        Invoke("OnePlayClick", 0.5f);
    }
    public void Buttom2()
    {        
        transform.position = posTwo.position;
        Invoke("TwoPlayClick", 0.5f);
    }
    //需要完全修改
    // Update is called once per frame
    private void OnePlayClick()
    {
        Map.Choice = 1;//单人
        mainUI.SetActive(false);
        Map.MapCreate();

    }
    private  void TwoPlayClick()
    {
        Map.Choice = 2;//双人
        mainUI.SetActive(false);
        Map.MapCreate();
    }
	void Update () {
     
	}
}
