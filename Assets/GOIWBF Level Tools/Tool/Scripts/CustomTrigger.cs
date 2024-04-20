using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class CustomTrigger : MonoBehaviour {

    public DetectMode Detect;
    public Trigger TriggerType;
    public bool Mode;
    public Vector3 Destination;
    public AudioClip Sound;
    public Transform[] GravityAtractors;
    public Animation animation;
    public string anim;
    public UnityEvent TriggerEvent;
    public GameObject[] TargetProp;

    private void Reset()
    {
        Destination = transform.position;
    }

    public enum Trigger
    {
        Reset,
        Teleport,
        Finish,
        Playsound,
        Animation,
        Event,
        SwitchScene
    }

    public enum DetectMode
    {
        PlayerOnly,
        PlayerAndProps,
        PropsOnly,
        SpecificProp,
    }

    private void OnDrawGizmos()
    {
        if (TriggerType == Trigger.Teleport)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(Destination, 0.25f);
            Gizmos.DrawLine(transform.position, Destination);
        }
    }
}
