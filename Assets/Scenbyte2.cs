using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenbyte2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Scenbytare2"))
        {

            SceneManager.LoadScene("LEVEL3");
        }
    }
}
