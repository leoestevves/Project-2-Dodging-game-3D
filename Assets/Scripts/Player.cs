using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float xInput;


    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        transform.Translate(xInput * moveSpeed * Time.deltaTime, 0, 0);

        if(transform.position.y <= -5f)
        {
            RestartScene();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Stone")
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}