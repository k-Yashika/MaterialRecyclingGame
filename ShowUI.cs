using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObj;

    private void Start()
    {
        uiObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObj.SetActive(true);
            StartCoroutine(WaitAndReload());
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator WaitAndReload()
    {
        yield return new WaitForSeconds(2);
        ReloadScene();
    }
}
