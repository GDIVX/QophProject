using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public float progress;
    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadScene(int index){
        StartCoroutine(ELoadScene(index));
    }

    IEnumerator ELoadScene(int index){
        //Load the scene in the background
        //Usefull for loading screens
        //or for large maps

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);
        
        //Cheack scene progress
        //Cheack if loading is done
        while(!asyncLoad.isDone){
            progress = asyncLoad.progress;
            yield return null;
        }
    }
        
}
