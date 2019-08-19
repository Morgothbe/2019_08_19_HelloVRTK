using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Autoload : MonoBehaviour
{
    public int levelIndex=1;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel(levelIndex);
    }


    public void LoadNext() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            LoadNext();
        }
    }
}
