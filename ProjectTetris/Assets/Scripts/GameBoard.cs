
using UnityEngine;
using UnityEngine.Tilemaps;

//The game board sees the bigger picture. It is responsible of ALL states of our game. Such as line clears, scoring, topping out
public class GameBoard : MonoBehaviour
{
    //We need a reference for our tilemap
    public Tilemap tilemap { get; private set; }
    public TetrisGamePiece activePiece { get; private set; } //Also have to reference to the tetris game piece class
    public Vector3Int spawnPosition; //We dont need to add a get and private set. Lets freely choose where we want to spawn the tetris piece.
    public TetriminoData[] tetrimino;

    //Pulling the built in Unity function Awake. This is for method that are called when the script instance is being loaded
    private void Awake()
    {
        
        this.tilemap = GetComponentInChildren<Tilemap>(); //The Tile map is a child of the GameBoard class
        this.activePiece = GetComponentInChildren<TetrisGamePiece>(); //The tetris game piece is a child of the gameboard Class

        //For every tetrimino piece. Call Initialize
        for (int i = 0; i < this.tetrimino.Length; i++)
        {
            this.tetrimino[i].Initialize();
        }
    }
    //At start. Call SpawnPiece function
    private void Start()
    {
        SpawnPiece();
    }

    //A public function called SpawnPiece.
    public void SpawnPiece()
    {
        //Typically in a tetris game the game will pick a random tetris piece at the start of the game.
        //Pick a random tetris piece to use for spawning
        int randomIndex = Random.Range(0, this.tetrimino.Length);

        //The specific tetris piece chosen will be assigned to the randomIndex chosen
        TetriminoData data = this.tetrimino[randomIndex];

        this.activePiece.Initialize(this, this.spawnPosition, data);
        Set(this.activePiece); //Call this function once the spawn piece function has been called
    }

    //Set the tetris piece to the gameboard
    public void Set(TetrisGamePiece tetrisPiece)
    {
        //Drawing the tetris piece
        for (int i = 0; i < tetrisPiece.cells.Length; i++)
        {
            Vector3Int tilePosition = tetrisPiece.cells[i] + tetrisPiece.position;
            this.tilemap.SetTile(tilePosition, tetrisPiece.data.tile);
        }
    }
}
