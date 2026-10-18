using UnityEngine;
// TODO: crea el ScriptableObject [CreateAssetsMenu...] recorda que no ha d'heretar de MonoBehaviour
[CreateAssetMenu(fileName = "NewAsteroidData", menuName = "Asteroids/Asteroid Data")]
public class AsteroidData : ScriptableObject
{
	//TODO: introdueix les dades necesaties
	public Vector3 escale;
	public float velocityMax;
	public float velocityMin;
	public int inpact;
	public int points;
	public Color color;
	public int damage;
}
