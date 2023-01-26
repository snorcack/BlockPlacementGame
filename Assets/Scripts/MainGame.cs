using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    Tile[,] tileCollection = new Tile[10, 10];
    public Tile DisplayTileRef;
    public BlockGenerator BlockGenRef;

    // Start is called before the first frame update
    void Start()
    {

        InitializeBoard();
    }
    /// <summary>
    /// Generate the initial board of tiles
    /// </summary>
    void InitializeBoard()
    {
        float tileGap = 0.5f;
        //float tileStartX = 1f;
        //float tileStartY = 1f;

        for (int i=0;i<10;i++)
        {
            for (int j=0;j<10;j++)
            {
                tileCollection[i, j] = GameObject.Instantiate<Tile>(DisplayTileRef);
                tileCollection[i, j].transform.parent = this.gameObject.transform;
                tileCollection[i, j].transform.position = new Vector3((i*tileGap), ((j * tileGap) + tileGap)*-1, 0);
                
            }
        }

        this.transform.position = new Vector3(-3, 3, 0);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateTileDisplay();
    }

    void UpdateTileDisplay()
    {

    }

    /// <summary>
    /// Checks if a block fits on the board. This runs for all kinds of blocks available for placement
    /// </summary>
    public void CheckBlockFit ()
    {
        int isAvailable =0 ;

        BlockGenRef.RefreshAvailableBlocks();

        for (int i=0;i<5;i++)
        {
            isAvailable += CheckBlockRotationFit(BlockGenRef.AvailableBlocks[i]);
        }

        Debug.Log("Available rotations are" + isAvailable);
    }



    /// <summary>
    /// This method will check each rotation for each block, if it can be placed on board.
    /// </summary>
    /// <param name="inBlock"></param>
    /// <returns></returns>
    public int CheckBlockRotationFit ( Block inBlock)
    {
        int rotations = 0;

        for (int i=0;i<inBlock.BlockPiecesRotations.Count;i++)
        {
            if (CheckTileAvailability (inBlock.BlockPiecesRotations[i]))
            {
                rotations++;
            }
        }
        return rotations;
    }


    /// <summary>
    /// This method checks if one specific rotation will fit on the space starting from the current tile.
    /// It will check each unfilled tile to check if a block can be accomodated.
    /// </summary>
    /// <param name="inBlockRot"></param>
    /// <returns></returns>
    public bool CheckTileAvailability (List<Vector2> inBlockRot)
    {
        for (int i=0;i<10;i++)
        {
            for (int j=0;j<10;j++)
            {
                if (!tileCollection[i,j].IsFilled)
                {
                    if (TrytileFit(inBlockRot, new Vector2(i, j)))
                        return true;
                }
            }
        }

        return false;
    }

    public bool TrytileFit (List<Vector2> inBlockRot, Vector2 tilePos)
    {
        for (int i = 0; i < inBlockRot.Count; i++)
        {
            if (!isTileEmpty(inBlockRot[i], tilePos))
            {
                return false;
            }
        }

        return true;
    }


    public bool isTileEmpty (Vector2 inCoordinate, Vector2 tilePos)
    {
        Vector2 tileCoord = inCoordinate + tilePos;

        if (TileInRange (tileCoord))
        {
            if (tileCollection[(int)tileCoord.x, (int)tileCoord.y].IsFilled)
            {
                return false;
            }
            return true;
        }
        return false;
    }

    public bool TileInRange (Vector2 coordinates)
    {
        if (coordinates.x < 0 || coordinates.x > 9)
            return false;

        if (coordinates.y < 0 || coordinates.y > 9)
            return false;


        return true;
    }

    public void RandomizeBoard()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if ((Random.Range(0,10) %2 )==0)
                {
                    tileCollection[i, j].FillTile();
                } else

                {
                    tileCollection[i, j].FillTile(false);
                }
            }
        }
    }
}
