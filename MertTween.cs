using UnityEngine;
using TMPro;

public static class MertTween
{
    public static void WriteText(TextMeshProUGUI textMesh , string textValue)
    {

        //Resources.Load

        textMesh.text = textValue;

    }
}
