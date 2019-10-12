using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    Button button;
    // private GameObject g;
    private GameObject h;





    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Tetris");
        DontDestroyOnLoad(gameObject);
       

        Debug.Log("Listner Added");
    }


  

    






    void Start()
    {
       



    }

    void Update()
    {

        
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


}
