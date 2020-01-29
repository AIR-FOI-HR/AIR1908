package md5d989dbc6697c59afd5707aa680383662;


public class ChildViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamDroid.ExpandableRecyclerView.ChildViewHolder, XamDroid.ExpandableRecyclerView", ChildViewHolder.class, __md_methods);
	}


	public ChildViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ChildViewHolder.class)
			mono.android.TypeManager.Activate ("XamDroid.ExpandableRecyclerView.ChildViewHolder, XamDroid.ExpandableRecyclerView", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
