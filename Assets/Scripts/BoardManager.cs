using UnityEngine;
using System;
using System.Collections;

public class BoardManager : MonoBehaviour {

    [Serializable]
    public class Count
    {
        public int minimum;
        public int maximum;
        public Count(int min, int max)
        {
            this.minimum = min;
            this.maximum = max;
        }
    }
    public int columns = 20;
    public int rows = 10; 
    public int offset;
    public int offsetValue = 64;
    public int xPos;
    public int yPos;
    public GameObject[] floorTiles;
    private Transform boardHolder;
    void InitializeList()
    {

    }

    void BoardSetup()
    {
        offset = 0; 
        for(int x = 0; x < columns; x++)
        {
            for(int y = 0; y < rows; y++)
            {
                GameObject toInsantiate = floorTiles[UnityEngine.Random.Range(0, floorTiles.Length)];
                yPos = y;
                xPos = x + 1;
                GameObject instance = Instantiate(toInsantiate, new Vector3(xPos, yPos, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
            offset++;
            if(offset > 1)
            {
                offset = 0;
            }
        }
    }
    public void SetupScence()
    {
        BoardSetup();
    }
}
