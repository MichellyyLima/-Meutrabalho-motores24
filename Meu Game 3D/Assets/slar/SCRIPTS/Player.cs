using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    public bool noChao;
    public Rigidbody rb;
    
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }
    
    void Update()
    {
         Debug.Log("UPDATE");
         float x = Input.GetAxis("Horizontal");
         float y = Input.GetAxis("Vertical");

         UnityEngine.Vector3 direcao = new Vector3(x,0,y);
         rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

         if (Input.GetKeyDown(KeyCode.Space) && noChao)
         {
             rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
             noChao = false;
         }
         if (transform.position.y < -5)
         {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
    }
    
}

