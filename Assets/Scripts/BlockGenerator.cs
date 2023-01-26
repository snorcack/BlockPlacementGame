using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    public List<Block> AvailableBlocks;

    public List<Block> BaseBlocks;

    // Start is called before the first frame update
    void Start()
    {
        AvailableBlocks = new List<Block>();
        BaseBlocks = new List<Block>();
        InitializeBlocks();
    }

    public void RefreshAvailableBlocks ()
    {
        AvailableBlocks.Clear();

        //BaseBlocks.Shuffle();

        for (int i=0;i<5;i++)
        {
            AvailableBlocks.Add(BaseBlocks[i]);
        }

    }   

    /// <summary>
    /// This method will create and save the rotation of all available block types. Can be moved to JSON later
    /// stored as vector coordinates of the block, the order of the tiles doesn't matter.
    /// </summary>
    private void InitializeBlocks ()
    {
        for (int i=0;i<6;i++)
        {
            BaseBlocks.Add(new Block());
        }

        // For block type   #
        //                 ##
        //                  #
        BaseBlocks[0].BlockPiecesRotations = new List<List<Vector2>>();
        BaseBlocks[0].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[0].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        BaseBlocks[0].BlockPiecesRotations[0].Add(new Vector2(1, 0));
        BaseBlocks[0].BlockPiecesRotations[0].Add(new Vector2(1, -1));
        BaseBlocks[0].BlockPiecesRotations[0].Add(new Vector2(1, 1));

        // For block type   #
        //                  ##
        //                  #
        BaseBlocks[0].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[0].BlockPiecesRotations[1].Add(new Vector2(0, 0));
        BaseBlocks[0].BlockPiecesRotations[1].Add(new Vector2(0, 1));
        BaseBlocks[0].BlockPiecesRotations[1].Add(new Vector2(0, 2));
        BaseBlocks[0].BlockPiecesRotations[1].Add(new Vector2(1, 1));

        // For block type   
        //                 ###
        //                  #
        BaseBlocks[0].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[0].BlockPiecesRotations[2].Add(new Vector2(0, 0));
        BaseBlocks[0].BlockPiecesRotations[2].Add(new Vector2(1, 0));
        BaseBlocks[0].BlockPiecesRotations[2].Add(new Vector2(2, 0));
        BaseBlocks[0].BlockPiecesRotations[2].Add(new Vector2(1, 1));

        // For block type   #
        //                 ###
        //                  
        BaseBlocks[0].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[0].BlockPiecesRotations[3].Add(new Vector2(0, 0));
        BaseBlocks[0].BlockPiecesRotations[3].Add(new Vector2(1, 0));
        BaseBlocks[0].BlockPiecesRotations[3].Add(new Vector2(2, 0));
        BaseBlocks[0].BlockPiecesRotations[3].Add(new Vector2(1, -1));


        // For block type   #
        //                  ##
        //                  
        BaseBlocks[1].BlockPiecesRotations = new List<List<Vector2>>();
        BaseBlocks[1].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[1].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        BaseBlocks[1].BlockPiecesRotations[0].Add(new Vector2(0, 1));
        BaseBlocks[1].BlockPiecesRotations[0].Add(new Vector2(1, 1));

        // For block type    #
        //                  ##
        //                  
        BaseBlocks[1].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[1].BlockPiecesRotations[1].Add(new Vector2(0, 0));
        BaseBlocks[1].BlockPiecesRotations[1].Add(new Vector2(0, 1));
        BaseBlocks[1].BlockPiecesRotations[1].Add(new Vector2(-1, 1));

        // For block type   ##
        //                   #
        //                  
        BaseBlocks[1].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[1].BlockPiecesRotations[2].Add(new Vector2(0, 0));
        BaseBlocks[1].BlockPiecesRotations[2].Add(new Vector2(1, 0));
        BaseBlocks[1].BlockPiecesRotations[2].Add(new Vector2(1, 1));

        // For block type    ##
        //                   #
        //                  
        BaseBlocks[1].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[1].BlockPiecesRotations[3].Add(new Vector2(0, 0));
        BaseBlocks[1].BlockPiecesRotations[3].Add(new Vector2(1, 0));
        BaseBlocks[1].BlockPiecesRotations[3].Add(new Vector2(0, 1));

        // For block type   #
        //                  #
        //                  ##
        BaseBlocks[2].BlockPiecesRotations = new List<List<Vector2>>();
        BaseBlocks[2].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[2].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        BaseBlocks[2].BlockPiecesRotations[0].Add(new Vector2(0, 1));
        BaseBlocks[2].BlockPiecesRotations[0].Add(new Vector2(0, 2));
        BaseBlocks[2].BlockPiecesRotations[0].Add(new Vector2(1, 2));

        // For block type   ##
        //                   #
        //                   #
        BaseBlocks[2].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[2].BlockPiecesRotations[1].Add(new Vector2(0, 0));
        BaseBlocks[2].BlockPiecesRotations[1].Add(new Vector2(0, 1));
        BaseBlocks[2].BlockPiecesRotations[1].Add(new Vector2(1, 1));
        BaseBlocks[2].BlockPiecesRotations[1].Add(new Vector2(1, 2));


        // For block type     #
        //                  ###
        //                  
        BaseBlocks[2].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[2].BlockPiecesRotations[2].Add(new Vector2(0, 0));
        BaseBlocks[2].BlockPiecesRotations[2].Add(new Vector2(0, 1));
        BaseBlocks[2].BlockPiecesRotations[2].Add(new Vector2(-1, 1));
        BaseBlocks[2].BlockPiecesRotations[2].Add(new Vector2(-2, 1));

        // For block type   ###
        //                  #
        //                  
        BaseBlocks[2].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[2].BlockPiecesRotations[3].Add(new Vector2(0, 0));
        BaseBlocks[2].BlockPiecesRotations[3].Add(new Vector2(1, 0));
        BaseBlocks[2].BlockPiecesRotations[3].Add(new Vector2(2, 0));
        BaseBlocks[2].BlockPiecesRotations[3].Add(new Vector2(0, 1));

        // For block type   ###
        //                  
        //                  
        BaseBlocks[3].BlockPiecesRotations = new List<List<Vector2>>();
        BaseBlocks[3].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[3].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        BaseBlocks[3].BlockPiecesRotations[0].Add(new Vector2(1, 0));
        BaseBlocks[3].BlockPiecesRotations[0].Add(new Vector2(2, 0));

        // For block type   #
        //                  #
        //                  #
        BaseBlocks[3].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[3].BlockPiecesRotations[1].Add(new Vector2(0, 0));
        BaseBlocks[3].BlockPiecesRotations[1].Add(new Vector2(0, 1));
        BaseBlocks[3].BlockPiecesRotations[1].Add(new Vector2(0, 2));

        // For block type    ##
        //                   ##
        //                  
        BaseBlocks[4].BlockPiecesRotations = new List<List<Vector2>>();
        BaseBlocks[4].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[4].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        BaseBlocks[4].BlockPiecesRotations[0].Add(new Vector2(0, 1));
        BaseBlocks[4].BlockPiecesRotations[0].Add(new Vector2(1, 0));
        BaseBlocks[4].BlockPiecesRotations[0].Add(new Vector2(1, 1));

        // For block type    #
        //                  
        //
        //
        /*
        BaseBlocks[5].BlockPiecesRotations.Add(new List<Vector2>());
        BaseBlocks[5].BlockPiecesRotations[0].Add(new Vector2(0, 0));
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class ListExtension
{
    private static System.Random rng = new System.Random();
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

}