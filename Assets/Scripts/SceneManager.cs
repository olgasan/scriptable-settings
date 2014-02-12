using UnityEngine;

public class SceneManager : MonoBehaviour 
{
	private void Start ()
	{
		ServerEnvironment e = ServerEnvironment.Development;
		Debug.Log (string.Format ("{0} environment domain is {1}", e, ServerSettings.Domain));
	}
}
