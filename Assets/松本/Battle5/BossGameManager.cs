using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossGameManager : MonoBehaviour
{
    public string sceneName;//読み込むシーン名

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(WolfManager.wolfnum==3)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
