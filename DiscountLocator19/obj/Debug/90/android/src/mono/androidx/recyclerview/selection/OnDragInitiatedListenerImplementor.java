package mono.androidx.recyclerview.selection;


public class OnDragInitiatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.recyclerview.selection.OnDragInitiatedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDragInitiated:(Landroid/view/MotionEvent;)Z:GetOnDragInitiated_Landroid_view_MotionEvent_Handler:AndroidX.RecyclerView.Selection.IOnDragInitiatedListenerInvoker, Xamarin.Android.Support.RecyclerView.Selection\n" +
			"";
		mono.android.Runtime.register ("AndroidX.RecyclerView.Selection.IOnDragInitiatedListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", OnDragInitiatedListenerImplementor.class, __md_methods);
	}


	public OnDragInitiatedListenerImplementor ()
	{
		super ();
		if (getClass () == OnDragInitiatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.RecyclerView.Selection.IOnDragInitiatedListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", "", this, new java.lang.Object[] {  });
	}


	public boolean onDragInitiated (android.view.MotionEvent p0)
	{
		return n_onDragInitiated (p0);
	}

	private native boolean n_onDragInitiated (android.view.MotionEvent p0);

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
