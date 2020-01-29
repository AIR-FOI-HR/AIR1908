package mono.androidx.recyclerview.selection;


public class OnContextClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.recyclerview.selection.OnContextClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onContextClick:(Landroid/view/MotionEvent;)Z:GetOnContextClick_Landroid_view_MotionEvent_Handler:AndroidX.RecyclerView.Selection.IOnContextClickListenerInvoker, Xamarin.Android.Support.RecyclerView.Selection\n" +
			"";
		mono.android.Runtime.register ("AndroidX.RecyclerView.Selection.IOnContextClickListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", OnContextClickListenerImplementor.class, __md_methods);
	}


	public OnContextClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnContextClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.RecyclerView.Selection.IOnContextClickListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", "", this, new java.lang.Object[] {  });
	}


	public boolean onContextClick (android.view.MotionEvent p0)
	{
		return n_onContextClick (p0);
	}

	private native boolean n_onContextClick (android.view.MotionEvent p0);

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
