using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject textoPonto;

    public static int ponto;

    void Update()
    {
        textoPonto.GetComponent<Text>().text = "Pontos: " + ponto;
    }
}
