package mono.androidx.recyclerview.selection;


public class OnItemActivatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.recyclerview.selection.OnItemActivatedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemActivated:(Landroidx/recyclerview/selection/ItemDetailsLookup$ItemDetails;Landroid/view/MotionEvent;)Z:GetOnItemActivated_Landroidx_recyclerview_selection_ItemDetailsLookup_ItemDetails_Landroid_view_MotionEvent_Handler:AndroidX.RecyclerView.Selection.IOnItemActivatedListenerInvoker, Xamarin.Android.Support.RecyclerView.Selection\n" +
			"";
		mono.android.Runtime.register ("AndroidX.RecyclerView.Selection.IOnItemActivatedListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", OnItemActivatedListenerImplementor.class, __md_methods);
	}


	public OnItemActivatedListenerImplementor ()
	{
		super ();
		if (getClass () == OnItemActivatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.RecyclerView.Selection.IOnItemActivatedListenerImplementor, Xamarin.Android.Support.RecyclerView.Selection", "", this, new java.lang.Object[] {  });
	}


	public boolean onItemActivated (androidx.recyclerview.selection.ItemDetailsLookup.ItemDetails p0, android.view.MotionEvent p1)
	{
		return n_onItemActivated (p0, p1);
	}

	private native boolean n_onItemActivated (androidx.recyclerview.selection.ItemDetailsLookup.ItemDetails p0, android.view.MotionEvent p1);

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
