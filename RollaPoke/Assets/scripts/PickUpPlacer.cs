using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPlacer : MonoBehaviour
{
    public Rotator Prefab;
    public int NumberOfPickUps;
    public int Length;
    public int Width;

    private Rotator[] PickUps;

    private void Start()
    {
        PickUps = new Rotator[NumberOfPickUps];
        for (int i = 0; i < NumberOfPickUps; i++)
        {
            float x = Random.Range(-Length, Length);
            float y = .75f;
            float z = Random.Range(-Width, Width);
            Vector3 position = new Vector3(x, y, z);
            PickUps[i] = Instantiate(Prefab, position, new Quaternion());
        }
    }
}
