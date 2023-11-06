using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public abstract class GridManager : MonoBehaviour
{
    public GameObject[] textContainers; 

    private static TextMeshProUGUI[] textMeshPros; 

    private void Start()
    {
        InitializeTextMeshPros();
        SetRandomText();
    }

    private void InitializeTextMeshPros()
    {
        textMeshPros = new TextMeshProUGUI[textContainers.Length];

        for (int i = 0; i < textContainers.Length; i++)
        {
            textMeshPros[i] = textContainers[i].GetComponentInChildren<TextMeshProUGUI>();
        }
    }

    public void SetRandomText()
    {
        foreach (TextMeshProUGUI textMeshPro in textMeshPros)
        {
            if (textMeshPro != null)
            {
                int randomValue = Random.Range(0, 2) * 2 + 2; // 2 or 4
                textMeshPro.text = randomValue.ToString();
            }
            // Debug.Log(textMeshPro);
        }
    }
}
