using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  public void MoveToScene(int sceneID)
  {
    SceneManager.LoadScene(sceneID);
  }

  public void QuitApp()
  {
    Debug.Log("Die");
    Application.Quit();
  }
}
