using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DIContainer.BindModules ();

		Employer boss = new Employer ();
		boss.InjectWorker (DIContainer.GetModule<IWorker>());
		boss.Enslave ();
	}
}