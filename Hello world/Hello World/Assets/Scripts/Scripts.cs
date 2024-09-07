using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnReanudar() {
        Debug.Log("El juego se reanudará");
    }

    public void BtnPlay() {
        Debug.Log("El juego comenzará");
    }

    public void BtnSalir() {
        Debug.Log("El juego se terminará");
    }

    public void icon1() {
        Debug.Log("Bienvenido a la tienda");
    }

    public void icon2() {
        Debug.Log("Bienvenido al chat");
    }

    public void icon3() {
        Debug.Log("Bienvenido a Discord");
    }

    public void icon4() {
        Debug.Log("Bienvenido a steam");
    }

    public void link1() {
        Application.OpenURL ("http://facebook.com");
    }

    public void link2() {
        Application.OpenURL ("http://instagram.com");
    }

    public void link3() {
        Application.OpenURL ("http://x.com");
    }

    public void reiniciar() {
        Debug.Log("Reiniciar juego");
    }

    public void menu() {
        Debug.Log("Abrir menú");
    }

    public void accion1() {
        Debug.Log("Hacer acción 1");
    }

    public void accion2() {
        Debug.Log("Hacer acción 2");
    }

    public void accion3() {
        Debug.Log("Hacer acción 3");
    }

    public void accion4() {
        Debug.Log("Hacer acción 4");
    }


}
