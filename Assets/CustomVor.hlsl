#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Random.hlsl"

float2 cell;
float2 cellPosition;
float2 toCell;
float distToCell;
float2 value;
float noise;
float Cust_Vor_Float;

float2 voronoiNoise(float2 value)
{
 float2 baseCell = floor(value);

    float minDistToCell = 10;
    [unroll]
    for(int x=-1; x<=1; x++){
        [unroll]
        for(int y=-1; y<=1; y++){
            float2 cell = baseCell + float2(x, y);
            float2 cellPosition = cell + InitRandom(cell);
            float2 toCell = cellPosition - value;
            float distToCell = length(toCell);
            if(distToCell < minDistToCell){
                minDistToCell = distToCell;
            }
        }
    }						
}

void Cust_Vor_float(float3 WorldPos, float cellSize, out float Out)
{		
		 value = WorldPos.xz / cellSize;
		 noise = voronoiNoise(value);
		
Out = noise;
}