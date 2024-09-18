using UnityEngine;
using System.Collections;


[RequireComponent(typeof(MeshFilter))]
public class BulletHoleDecal : MonoBehaviour
{
	static private Vector2[] quadUVs = new Vector2[]{new Vector2(0,0), new Vector2(0,1), new Vector2(1,0), new Vector2(1,1)};
	
	public float lifetime = 10f;
	public float fadeoutpercent = 80;
	public Vector2 frames;
	public bool randomRotation = false;
	
	private float life;
	private float fadeout;
	private Color color;
	private float orgAlpha;


	void OnEnable()
	{
		//Random UVs
		int random = Random.Range(0, (int)(frames.x*frames.y));
		int fx = (int)(random%frames.x);
		int fy = (int)(random/frames.y);
		//Set new UVs
		Vector2[] meshUvs = new Vector2[4];
		for(int i = 0; i < 4; i++)
		{
			meshUvs[i].x = (quadUVs[i].x + fx) * (1.0f/frames.x);
			meshUvs[i].y = (quadUVs[i].y + fy) * (1.0f/frames.y);
		}
		this.GetComponent<MeshFilter>().mesh.uv = meshUvs;
		
		//Random rotate
		if(randomRotation)
			this.transform.Rotate(0f,0f,Random.Range(0f,360f), Space.Self);
		
	}

}
