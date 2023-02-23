using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Vuforia;

public class CardRecoScript : MonoBehaviour
{
public AudioClip musicFx;
 private void Start()

{

VuforiaBehaviour.Instance.DevicePoseBehaviour.OnTargetStatusChanged += OnDevicePoseStatusChanged;

}

void OnDevicePoseStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)

{

Debug.Log("OnDevicePoseStatusChanged(" + targetStatus.Status + ", " + targetStatus.StatusInfo + ")");

if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)

{

//lancio la musica
             Debug.Log("suono");
            AudioManagerScript.current.PlaySound(musicFx);

}



else

{ 
    // stoppo la musica
            AudioManagerScript.current.StopSound();
            //  Debug.Log("stoppo");
}

}
}