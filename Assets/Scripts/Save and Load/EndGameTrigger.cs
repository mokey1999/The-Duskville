using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SaveManager.instance.DeleteSavedData();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
