using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Levelmanager : MonoBehaviour
{
    public Button master,start;
    public string masterscene="Master";
    public GameObject leverltext;
    // Start is called before the first frame update
    void Start()
    {
        master.onClick.AddListener(returntomaster);
        start.onClick.AddListener(levelstart);
    }

    private void levelstart()
    {
        if (leverltext.activeInHierarchy)
        {
            leverltext.SetActive(false);
        }
        else
        {
            leverltext.SetActive(true);
        }
        
    }

    private void returntomaster()
    {
        SceneManager.LoadScene(masterscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
