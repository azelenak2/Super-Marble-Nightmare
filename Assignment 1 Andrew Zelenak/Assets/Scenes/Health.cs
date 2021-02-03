using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Text HealthBar;
    public GameObject ball;

    public int maxhealth = 100;
    public int currenthealth = 100;

    

    // Start is called before the first frame update
    void Start()
    {
        

        maxhealth = currenthealth;
    }

    // Update is called once per frame


    
        





    private void Update()
    {
        HealthBar.text = maxhealth.ToString();

        if (maxhealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}


