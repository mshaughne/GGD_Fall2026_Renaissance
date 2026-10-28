using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager3D : MonoBehaviour
{
    [SerializeField] private Grid grid;
    [SerializeField] private int width = 10;
    [SerializeField] private int depth = 10;

    private bool[,] occupiedCells;
    private bool[,] blockedCells;

    private void Awake()
    {
        if (grid == null)
            grid = GetComponent<Grid>();

        occupiedCells = new bool[width, depth];
        blockedCells = new bool[width, depth];
    }

    public Vector3Int WorldToCell(Vector3 worldPos)
    {
        return grid.WorldToCell(worldPos);
    }

    public Vector3 GetCellCenter(Vector3Int cell)
    {
        Vector3 corner = grid.CellToWorld(cell);

        return new Vector3(corner.x + grid.cellSize.x * 0.5f,
            grid.transform.position.y,
            corner.z + grid.cellSize.z * 0.5f);
    }

    public bool IsInsideGrid(Vector3Int cell)
    {
        return cell.x >= 0 && cell.x < width
            && cell.z >= 0 && cell.z < depth;
    }

    public bool IsOccupied(Vector3Int cell)
    {
        if (!IsInsideGrid(cell)) return true;

        return occupiedCells[cell.x, cell.z];
    }

    public bool TryOccupyCell(Vector3Int cell)
    {
        if (IsOccupied(cell) || IsBlocked(cell)) return false;

        occupiedCells[cell.x, cell.z] = true;
        return true;
    }

    public bool IsBlocked(Vector3Int cell)
    {
        if (!IsInsideGrid(cell)) return true;

        return blockedCells[cell.x, cell.z];
    }

    public void FreeCell(Vector3Int cell)
    {
        if(IsInsideGrid(cell))
        {
            occupiedCells[cell.x, cell.z] = false;
        }
    }

    public void SetBlocked(Vector3Int cell, bool blocked)
    {
        if(IsInsideGrid(cell))
        {
            blockedCells[cell.x, cell.z] = blocked;
        }
    }
}
