using UnityEngine;

public class vapen : MonoBehaviour
{
    public GameObject weaponObject;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("glock"))
        {
            weaponObject.SetActive(true);
        }
    }
}
