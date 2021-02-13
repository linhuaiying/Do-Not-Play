using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 目前没有任何作用.
/// </summary>
public class Play2born : MonoBehaviour
{
    public static Play2born instance;
    public GameObject playerPrefab;
    // Use this for initialization
    public static Play2born Instance
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
    void Start()
    {
        Invoke("BornTank2", 1f);
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BornTank2()
    {

        Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
