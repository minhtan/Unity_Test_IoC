using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DIContainer {
	static Dictionary<Type, object> registeredModules = new Dictionary<Type, object>();

	public static void BindModules(){
//		DIContainer.SetModule<IWorker> (new WorkerImpl1 ());
		DIContainer.SetModule<IWorker> (new WorkerImpl2 ());
	}

	public static void SetModule<T>(object module) {
		registeredModules.Add (typeof(T), module);
	}

	public static T GetModule<T>() {
		Type t = typeof(T);
		if (registeredModules.ContainsKey (t)) {
			return (T)registeredModules [t];
		} else {
			return default(T);
		}
	}

}
