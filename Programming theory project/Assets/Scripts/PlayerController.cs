using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] float xRange = 15.0f;
    [SerializeField] float zRange = 5.0f;

    public GameObject ammo;
    
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;

    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.z < - zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,-zRange);
        }
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
           Instantiate(ammo, transform.position, ammo.transform.rotation);
          
        }
        
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
