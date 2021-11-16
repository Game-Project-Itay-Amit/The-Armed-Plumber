using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] string sceneName;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            Debug.Log("EndPortal touched");
            SceneManager.LoadScene(sceneName);
        }
    }
}
