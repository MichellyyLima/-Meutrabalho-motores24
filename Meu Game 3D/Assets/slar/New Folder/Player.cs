using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("UPDATE");
         float x = Input.GetAxis("Horizontal");
         float y = Input.GetAxis("Vertical");

         UnityEngine.Vector3 direcao = new Vector3(x,0,y);
         rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
