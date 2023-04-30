using UnityEngine;

public enum PieceTypes
{
    Red = 0,
    Orange = 1,
    Blue = 2,
    Purple = 3,
    Green = 4
}

public class Piece
{
    // This script will manage the state of a single
    // piece in the grid.

    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;
    private bool setForDestruction;

    public Piece()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
        pieceType = PieceTypes.Purple;
        setForDestruction = false;
    }

    public Piece(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = PieceTypes.Purple;
        this.setForDestruction = false;
    }

    public Piece(Vector3 position, Vector2 gridPosition, PieceTypes pieceType)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = pieceType;
        this.setForDestruction = false;
    }

    public void SetForDestruction()
    {
        this.setForDestruction = true;
    }

    public void SetPieceType(PieceTypes pieceType)
    {
        this.pieceType = pieceType;
    }

    public void SetGridPosition(Vector2 position)
    {
        this.gridPosition = position;
    }

    public Vector3 GetPosition()
    {
        return position;
    }

    public Vector3 GetGridPosition()
    {
        return gridPosition;
    }

    public PieceTypes GetPieceType()
    {
        return pieceType;
    }

    public bool GetDestruction()
    {
        return setForDestruction;
    }
}