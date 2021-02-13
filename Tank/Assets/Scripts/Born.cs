using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Born : MonoBehaviour {

    public GameObject player1Prefab;
    public GameObject player2Prefab;

    public GameObject[] enemyPrefabList;

    public int createPlayer;
    Vector3 vectorP1 = new Vector3(-2, 8, 0);
    Vector3 vectorP2 = new Vector3(2, 8, 0);
    // Use this for initialization
    void Start () {
        Invoke("BornTank", 1f);
        Destroy(gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void BornTank()
    {
        if (createPlayer==1)
        {
           Instantiate(player1Prefab, transform.position, Quaternion.identity);
        }
        if(createPlayer==2)
        {
            Instantiate(player2Prefab, transform.position, Quaternion.identity);
        }
        else
        {
            int num = Random.Range(0, 2);
            Instantiate(enemyPrefabList[num], transform.position, Quaternion.identity);
        }
        
    }
}
