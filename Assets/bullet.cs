using UnityEngine;
using TMPro;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float bulletLifetime = 5f;
    public int maxAmmo = 5;

    private int currentAmmo;
    private bool canShoot = false;
    private bool isReloading = false;

    public TMP_Text infoText;

    void Start()
    {
        currentAmmo = maxAmmo;
        UpdateInfoText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("glock"))
        {
            canShoot = true;
            isReloading = false;
            UpdateInfoText();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("glock"))
        {
            canShoot = false;
            UpdateInfoText();
        }
    }

    void Update()
    {
        if (isReloading)
            return;

        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }

            if (Input.GetKeyDown(KeyCode.R) && currentAmmo <= 0)
            {
                Reload();
            }

            UpdateInfoText();
        }
    }

    void Shoot()
    {
        if (currentAmmo > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 shootDirection = (mousePosition - transform.position).normalized;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(shootDirection.x, shootDirection.y) * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            currentAmmo--;
            UpdateInfoText();
        }
    }

    void Reload()
    {
        isReloading = true;
        Invoke("FinishReload", 1f);
    }

    void FinishReload()
    {
        currentAmmo = maxAmmo;
        isReloading = false;
        UpdateInfoText();
    }

    void UpdateInfoText()
    {
        if (canShoot)
        {
            if (currentAmmo <= 0)
            {
                infoText.text = "PRESS R TO RELOAD";
            }
            else
            {
                infoText.text = "";
            }
        }
    }
}
