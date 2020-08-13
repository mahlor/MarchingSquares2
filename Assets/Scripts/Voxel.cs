using UnityEngine;
using System;

[Serializable]
public class Voxel
{
    public bool state;
    public Vector2 position, xEdgePosition, yEdgePosition;

    public Voxel (int x, int y, float size)
    {
        position.x = (x + 0.5f) * size;
        position.y = (y + 0.5f) * size;

        xEdgePosition = position;
        xEdgePosition.x += size * 0.5f;
        yEdgePosition = position;
        yEdgePosition.y += size * 0.5f;
    }
    public Voxel() { }
    public void BecomeDummyOf(Voxel voxel, float offset, int axis)
    {

        state = voxel.state;
        position = voxel.position;
        xEdgePosition = voxel.xEdgePosition;
        yEdgePosition = voxel.yEdgePosition;
        switch (axis)
        {
            case 0:
                position.y += offset;
                xEdgePosition.y += offset;
                yEdgePosition.y += offset;
                break;
            case 1:
                position.x += offset;
                xEdgePosition.x += offset;
                yEdgePosition.x += offset;
                break;
            case 2:
                position.y += offset;
                xEdgePosition.y += offset;
                yEdgePosition.y += offset;

                position.x += offset;
                xEdgePosition.x += offset;
                yEdgePosition.x += offset;
                break;
        }
    }
}
