using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    AsyncOperation async;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectScene()
    {
        async = SceneManager.LoadSceneAsync(index);
        async.allowSceneActivation = true;
    }

}
