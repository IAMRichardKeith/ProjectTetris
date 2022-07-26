using UnityEngine;
using UnityEngine.Tilemaps;

//An Enumator of Tetris pieces. There are I, O, T, J, L, S and Z pieces
public enum Tetriminos
{
    IPiece,
    OPiece,
    TPiece,
    JPiece,
    LPiece,
    SPiece,
    ZPiece,
}

[System.Serializable]

//We want to create a struct of Tetrimino data. Assign the specific tetrimino to its respective color tile
public struct TetriminoData
{
    public Tetriminos tetriminos;
    public Tile tile;
    public Vector2Int[] cells {get; private set;} //<-- This property allows the cells data to not be viewable on the Unity Editor.


    public void Initialize()
    {
        //Access the data class and cells property. We are now looking up the cells associated with the tetromino data
        this.cells = Data.Cells[this.tetriminos] //Assigning our cells to the tetrimino data
    }

}
