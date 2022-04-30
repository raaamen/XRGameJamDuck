using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    public GameObject sphere;
    [SerializeField] private AudioSource m_audio;
    [SerializeField] private Vector3 m_scaleChange = new Vector3(0.1f,0.1f,0.1f);
    private GameManager gameManager;
    private Movement movement;
    [SerializeField] private TextMeshProUGUI eggScore;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        movement = sphere.GetComponent<Movement>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("pickup"))
        {
            if (m_audio) m_audio.Play();
            movement.m_speed += 0.5f;
            transform.localScale += m_scaleChange;
            Destroy(collision.gameObject);
            gameManager.EggCollected();
            eggScore.text = gameManager.eggsCollected.ToString();

        }
    }
}
