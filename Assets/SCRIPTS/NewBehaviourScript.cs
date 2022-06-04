using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text= "Escoge una inicial";
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.A))
       {
           texto.text="Eres un Lord Sith";
       }  
       if (Input.GetKeyDown(KeyCode.B))
       {
           texto.text="Eres un Maestro Jedi";
       }
       if (Input.GetKeyDown(KeyCode.C))
       {
           texto.text="Eres un Aprendiz Jedi";
       }
       if (Input.GetKeyDown(KeyCode.D))
       {
           texto.text="Ganaste el Apodo Darth";
       }
    }
}