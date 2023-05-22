using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class scenemanager : MonoBehaviour
{
    public Button scene1,scene2,scene3;
    public string scenename1, scenename2, scenename3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        scene1.onClick.AddListener(scene1loader);
        scene2.onClick.AddListener(scene2loader);
        scene3.onClick.AddListener(scene3loader);
    }

    private void scene3loader()
    {
        Debug.Log("Button 3 Pressed");
        SceneManager.LoadScene(scenename3);
    }

    private void scene2loader()
    {
        Debug.Log("Button 2 Pressed");
        SceneManager.LoadScene(scenename2);
    }

    private void scene1loader()
    {
        Debug.Log("Button 1 Pressed");
        SceneManager.LoadScene(scenename1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
