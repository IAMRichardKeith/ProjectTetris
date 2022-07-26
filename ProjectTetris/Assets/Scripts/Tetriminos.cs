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
    public Vector2Int[] cells;

}
