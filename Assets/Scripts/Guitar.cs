using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : MonoBehaviour
{
    public void FindGuitar()
    {
        Managers.Game.FindPresent(Define.Present.Guitar, "기타");
    }
}
