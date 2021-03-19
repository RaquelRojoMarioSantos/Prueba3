using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrBoton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Text").GetComponent<Text>().text = "";
    }

    public void PulsarBoton()
    {
        GameObject.Find("Text").GetComponent<Text>().text = "Hola, mundo!!!";
    }
}
