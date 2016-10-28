using UnityEngine;
using System.Collections;

public class WorkerImpl1 : IWorker {
	#region IWork implementation
	public void DoTask (string taskName)
	{
		Debug.Log ("Worker 1 doing: " + taskName);
	}
	#endregion
}
