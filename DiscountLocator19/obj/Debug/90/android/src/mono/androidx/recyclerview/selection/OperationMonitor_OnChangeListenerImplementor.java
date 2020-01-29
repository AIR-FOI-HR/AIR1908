package mono.androidx.recyclerview.selection;


public class OperationMonitor_OnChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.recyclerview.selection.OperationMonitor.OnChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChanged:()V:GetOnChangedHandler:AndroidX.RecyclerView.Selection.OperationMonitor/IOnChangeListenerInvoker, Xamarin.Android.Support.RecyclerView.Selection\n" +
			"";
		mono.android.Runtime.register ("AndroidX.RecyclerView.Selection.OperationMonitor+IOnChangeListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", OperationMonitor_OnChangeListenerImplementor.class, __md_methods);
	}


	public OperationMonitor_OnChangeListenerImplementor ()
	{
		super ();
		if (getClass () == OperationMonitor_OnChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.RecyclerView.Selection.OperationMonitor+IOnChangeListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", "", this, new java.lang.Object[] {  });
	}


	public void onChanged ()
	{
		n_onChanged ();
	}

	private native void n_onChanged ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
