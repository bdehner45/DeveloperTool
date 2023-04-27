using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    [Header("UI Screens")]
    [SerializeField] private GameObject loadingScreenCanvas;
    [SerializeField] private GameObject GameOverCanvas;

    [Header("Slider")]
    [SerializeField] private Slider loadingSlider;

    public void LoadLevel(string LoadLevel)
    {
        GameOverCanvas.SetActive(false);
        loadingScreenCanvas.SetActive(true);

        StartCoroutine(LevelLoadAsync(LoadLevel));
    }


    IEnumerator LevelLoadAsync(string levelToLoad)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
       
        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 1f);
            loadingSlider.value = progressValue;
           
            yield return null;
        }
        
    }
}
