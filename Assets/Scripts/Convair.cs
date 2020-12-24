using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convair : MonoBehaviour
{
    public GameObject[] presents;
    [SerializeField]
    Transform startPos;

    float spawnTime = 3f;
    float elapsedTime = 0;

    private void Update()
    {
        if (Managers.Game.presents.Count == 0)
            return;
        elapsedTime += Time.deltaTime;

        if(spawnTime <= elapsedTime)
        {
            elapsedTime = 0;

            for (int i = 0; i < presents.Length; i++)
            {
                SelectPresent PR = presents[i].GetComponent<SelectPresent>();
                if(Managers.Game.presents[0] == PR.present)
                {
                    Managers.Game.presents.RemoveAt(0);
                    GameObject go = Instantiate(presents[i], startPos);
                    go.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
}
