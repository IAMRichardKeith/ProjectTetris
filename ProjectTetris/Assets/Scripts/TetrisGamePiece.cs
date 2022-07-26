using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tetris game piece class. We will go through the individual game pieces and apply logic to the pieces only such as inputs, controls
//moving the piece
public class TetrisGamePiece : MonoBehaviour
{

    public GameBoard gameBoard { get; private set; }
    public TetriminoData data { get; private set; }

    public Vector3Int position { get; private set; } //A tilemap uses vector3 int not vector2

    //We need a new array of cells because when the spawned pieces get rotated, that is when the values of the specific tetris piece change.
    public Vector3Int[] cells { get; private set; }
  

    //Initialize function. Passing in a reference to the game board, initial position and the specific tetrimino data
    //Some things we will have to consider. Where do we want to spawn the tetris piece and what kind of tetris data are we passing?
    //The tetrimino will have to continuously communicate with the gameboard class for specific events that happen in the game.
    public void Initialize(GameBoard gameBoard, Vector3Int position, TetriminoData data)
    {
        //Passing
        this.gameBoard = gameBoard;
        this.position = position;
        this.data = data;

        //If our array has nothing. Add something
        if(this.cells == null)
        {
            this.cells = new Vector3Int[data.cells.Length]; //Every tetris piece has 4 cells in them
        }

        for (int i = 0; i < data.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i]; //Casting our cells to Vector3Int
        }
    }

    private void Update()
    {
        //Press the arrow keys to move the tetris piece
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }

    private void Move(Vector2Int translation)
    {
        
    }

}

