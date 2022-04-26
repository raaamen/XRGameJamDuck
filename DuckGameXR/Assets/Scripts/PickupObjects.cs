using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    [SerializeField] private AudioSource m_audio;
    [SerializeField] private Vector3 m_scaleChange = new Vector3(0.1f,0.1f,0.1f);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("pickup"))
        {
            if (m_audio) m_audio.Play();
            transform.localScale += m_scaleChange;
            Destroy(collision.gameObject);
        }
    }
}
