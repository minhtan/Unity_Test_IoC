using UnityEngine;
using System.Collections;

public class WorkerImpl2 : IWorker {
	#region IWorker implementation

	public void DoTask (string taskName)
	{
		Debug.Log ("Worker 2 refuse to do: " + taskName);
	}

	#endregion
}
