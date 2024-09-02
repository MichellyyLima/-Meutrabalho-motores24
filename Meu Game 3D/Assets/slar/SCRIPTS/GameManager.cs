using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgvitoria;
    public int restantes;
    public AudioClip clipmoeda, clipVitoria;

    private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<COIN>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        source.PlayOneShot(clipmoeda);
            
        if (restantes <= 0)
        {
            //Ganhou o jogo
            msgvitoria.text = "Parabéns";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
