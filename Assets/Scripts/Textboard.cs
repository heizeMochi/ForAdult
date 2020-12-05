using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textboard : MonoBehaviour
{
    [SerializeField]
    Text nameText, text;

    private void Start()
    {
        StartCoroutine(Talk("MYNAME", "안녕 나는 MYNAME이라고 해 잘 부탁해"));
    }

    IEnumerator Talk(string name, string context)
    {
        nameText.text = name;
        text.text = "";

        char[] conchar = context.ToCharArray();

        for (int i = 0; i < conchar.Length; i++)
        {
            text.text += conchar[i];
            yield return new WaitForSeconds(0.01f);
        }

        yield return null;
    }

}
