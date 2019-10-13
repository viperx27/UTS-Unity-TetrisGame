using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync(1);
        DontDestroyOnLoad(gameObject);


        Debug.Log("Listner Added");
    }




}
