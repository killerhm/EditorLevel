using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int sizeX, sizeZ;
    public GameObject groundPrefab;
    public GameObject wallPrefab;
    public GameObject emptyPrefab;
    public List<Texture> textures = new List<Texture>();

    public Texture emptyTexture;
    public Texture wallTexture;
    public Texture groundTexture;

    public GUISkin skin;

    public void GenerateMap()
    {

        int z = 0;
        int x = 0;
            for (int i = 0; i < textures.Count; i++)
            {
            if (i % 5 == 0) { x = 0; z++; }
            x++;
                if(textures[i] == wallTexture)
                {
                    GameObject wallTileGo = Instantiate(wallPrefab, new Vector3(x, 0, z), Quaternion.identity);
                }
                else if (textures[i] == groundTexture)
                {
                    GameObject wallTileGo = Instantiate(groundPrefab, new Vector3(x, 0, z), Quaternion.identity);
                }
                
            }
        
        
    }

    public void addNewTexture(int dir)
    {
        if (dir > 0)
            textures.Add(emptyTexture);
        else
            textures.RemoveAt(textures.Count - 1);
    }

}

public class MapData
{
    public TileType tileType;
    public enum TileType { Ground = 0, Wall = 1}
}
