using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 目前没有任何作用
/// </summary>
public class Play1born : MonoBehaviour
{
    public static Play1born instance;
    public GameObject playerPrefab;
    public static Play1born Instance
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
    // Use this for initialization
    void Start()
    {

        Invoke("BornTank1", 1f);
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BornTank1()
    {

            Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
