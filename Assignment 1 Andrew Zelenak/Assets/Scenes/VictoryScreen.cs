using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void Update()
    {
        if (player.transform.position.z >= 0.29)
        {
            SceneManager.LoadScene(3);
        }
    }
}