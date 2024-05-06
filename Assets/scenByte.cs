using UnityEngine;
using UnityEngine.SceneManagement;

public class scenByte : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("scenBytare"))
        {
           
            SceneManager.LoadScene("LEVEL2");
        }
    }
}
