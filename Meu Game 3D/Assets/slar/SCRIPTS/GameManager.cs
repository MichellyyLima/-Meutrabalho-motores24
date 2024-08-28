using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgvitoria;
    public int restantes;
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<COIN>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        
        if (restantes <= 0)
        {
            //Ganhou o jogo
            msgvitoria.text = "uhuu";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
