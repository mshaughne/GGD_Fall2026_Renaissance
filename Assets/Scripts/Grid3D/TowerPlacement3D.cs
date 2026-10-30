using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement3D : MonoBehaviour
{
    [SerializeField] private GridManager3D gridManager;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private LayerMask groundLayers;

    private void Awake()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TryPlaceTower();
        }
    }

    private void TryPlaceTower()
    {
        if (gridManager == null || mainCamera == null || towerPrefab == null)
            return;

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if(!Physics.Raycast(ray, out RaycastHit hit, 250f, groundLayers))
        {
            return;
        }

        Vector3Int cell = gridManager.WorldToCell(hit.point);

        if (gridManager.IsOccupied(cell) || gridManager.IsBlocked(cell))
        {
            return;
        }

        if(gridManager.TryOccupyCell(cell))
        {
            Vector3 position = gridManager.GetCellCenter(cell);
            Instantiate(towerPrefab, position, Quaternion.identity);
        }
    }
}