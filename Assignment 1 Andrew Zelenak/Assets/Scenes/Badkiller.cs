using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badkiller : MonoBehaviour

{
    public GameObject hat;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}