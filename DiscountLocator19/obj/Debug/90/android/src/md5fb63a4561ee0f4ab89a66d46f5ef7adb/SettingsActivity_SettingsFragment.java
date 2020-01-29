package md5fb63a4561ee0f4ab89a66d46f5ef7adb;


public class SettingsActivity_SettingsFragment
	extends android.support.v7.preference.PreferenceFragmentCompat
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreatePreferences:(Landroid/os/Bundle;Ljava/lang/String;)V:GetOnCreatePreferences_Landroid_os_Bundle_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("DiscountLocator19.SettingsActivity+SettingsFragment, DiscountLocator19", SettingsActivity_SettingsFragment.class, __md_methods);
	}


	public SettingsActivity_SettingsFragment ()
	{
		super ();
		if (getClass () == SettingsActivity_SettingsFragment.class)
			mono.android.TypeManager.Activate ("DiscountLocator19.SettingsActivity+SettingsFragment, DiscountLocator19", "", this, new java.lang.Object[] {  });
	}


	public void onCreatePreferences (android.os.Bundle p0, java.lang.String p1)
	{
		n_onCreatePreferences (p0, p1);
	}

	private native void n_onCreatePreferences (android.os.Bundle p0, java.lang.String p1);

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
