using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperInTheWind : MonoBehaviour {

    public List<ParticleSystem> papers = new List<ParticleSystem>();
    public AudioSource audioSource;

    private int timesPlayed;
    public float clock;
    public int rn;

    private void Start()
    {
        rn = GetRandomNumber();
    }

    public int GetRandomNumber()
    {
        int randomnumber;
        if (timesPlayed > 0)
        {
            randomnumber = Random.Range(12, 25);
        }
        else
        {
            randomnumber = Random.Range(5, 10);
        }
        timesPlayed += 1;
        return randomnumber;
    }

    private void Update()
    {
        clock += Time.deltaTime;

        if (clock >= rn)
        {
            Wind();
            clock = 0;
            rn = GetRandomNumber();
        }
    }

    public void Wind()
    {
        int index = 0;
        for (int i = 0; i < papers.Count; i++)
        {
            papers[index].Play();
            index += 1;
        }
        audioSource.Play();
    }



}
