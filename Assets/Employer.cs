using UnityEngine;
using System.Collections;

public class Employer : IInjectWorker {
	IWorker worker;

	#region constructor injection 
//	void Employer(){
//		worker = new WorkerImpl1 ();
//	}
	#endregion

	#region setter injection //each dependency need a setter
//	void SetModul(IWorker worker){
//		this.worker = worker;
//	}
	#endregion

	#region IInjectWorker implementation
	public void InjectWorker (IWorker worker)
	{
		this.worker = worker;
	}
	#endregion

	public void Enslave(){
		worker.DoTask ("some bullshit");
	}
}
