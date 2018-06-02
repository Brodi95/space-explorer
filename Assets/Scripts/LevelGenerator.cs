
using UnityEngine;

public class LevelGenerator : MonoBehaviour {


    public Texture2D map;
    public ColorToPrefab[] colorMappings;
    public GameObject[] FloorTiles;
    public GameObject MapEnd;
	// Use this for initialization
	void Start ()
    {

        GenerateLevel();
	}

    void GenerateLevel()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                if (x == 0 || y == 0 || x == map.width-1 || y == map.height-1)
                {
                    (Instantiate(MapEnd, new Vector2(x, y), Quaternion.identity) as GameObject).transform.parent = transform;
                }
                GenerateTile(x, y);
            }
        }
    }

    void GenerateTile(int x, int y)
    {
        Color _pixelColor = map.GetPixel(x, y);

        //if (_pixelColor.a == 0)
        //{
        //    _pixelColor.r = 2;
        //    //pixel is transparent ignore it lol
        //    return;
        //}
        Vector2 _position = new Vector2(x, y);
        (Instantiate(FloorTiles[Random.Range(0, FloorTiles.Length)], _position, Quaternion.identity) as GameObject).transform.parent = transform;
        foreach (ColorToPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(_pixelColor))
            {
                Debug.Log(" Color Red Blue Green" + _pixelColor.r + _pixelColor.b + _pixelColor.g);
                (Instantiate(colorMapping.prefab, _position, Quaternion.identity)as GameObject).transform.parent = transform;
            }
        }
    }
}
