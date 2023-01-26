using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block  
{
    // Start is called before the first frame update

    internal List<Vector2> BlockPieces;
    internal List<List<Vector2>> BlockPiecesRotations;


    public List<List<Vector2>> GetBlockRotations()
    {
        return BlockPiecesRotations;
    }
}
