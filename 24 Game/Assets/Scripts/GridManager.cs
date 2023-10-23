using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GridManager : MonoBehaviour
{
    public GameObject[] textContainers; // Assign your parent GameObjects in the Inspector.
    private static TextMeshProUGUI[] textMeshPros; // Array to store TextMeshPro components.

    private void Start()
    {
        InitializeTextMeshPros();
        SetRandomText();
    }

    // Initialize the static array of TextMeshPro components.
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
                int randomValue = Random.Range(0, 2) * 2 + 2;
                textMeshPro.text = randomValue.ToString();
            }
        }
        Debug.Log("Text set.");
    }
}
