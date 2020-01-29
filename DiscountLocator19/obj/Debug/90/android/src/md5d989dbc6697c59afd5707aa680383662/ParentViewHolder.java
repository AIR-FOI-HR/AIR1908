package md5d989dbc6697c59afd5707aa680383662;


public class ParentViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XamDroid.ExpandableRecyclerView.ParentViewHolder, XamDroid.ExpandableRecyclerView", ParentViewHolder.class, __md_methods);
	}


	public ParentViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ParentViewHolder.class)
			mono.android.TypeManager.Activate ("XamDroid.ExpandableRecyclerView.ParentViewHolder, XamDroid.ExpandableRecyclerView", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
