using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomHitSoundProvider : MonoBehaviour {

	public CustomHitSound[] hitSounds;
	public Dictionary<string, CustomHitSound> hitDict = new Dictionary<string, CustomHitSound>();

	private void Awake()
    {
		foreach (CustomHitSound h in hitSounds)
        {
			hitDict.Add(h.name, h);
        }
    }

	public AudioClip GetHit(string mat)
	{
		if (hitDict.ContainsKey(mat))
			return hitDict[mat].GetHit();
		else return null;
	}

	public AudioClip GetHardHit(string mat)
	{
		if (hitDict.ContainsKey(mat))
			return hitDict[mat].GetHardHit();
		else return null;
	}

	public AudioClip GetScrape(string mat)
	{
		if (hitDict.ContainsKey(mat))
			return hitDict[mat].GetScrape();
		else return null;
	}
}

[Serializable]
public class CustomHitSound
{
	public string name;
	public List<AudioClip> hits;
	public List<AudioClip> hardHits;
	public List<AudioClip> scrapes;

	public AudioClip GetHit()
	{
		if (hits.Count > 0)
			return hits[UnityEngine.Random.Range(0, hits.Count)];
		else return null;
	}

	public AudioClip GetHardHit()
	{
		if (hits.Count > 0)
			return hardHits[UnityEngine.Random.Range(0, hardHits.Count)];
		else return GetHit();
	}

	public AudioClip GetScrape()
	{
		if (scrapes.Count > 0)
			return scrapes[UnityEngine.Random.Range(0, scrapes.Count)];
		else return null;
	}
}