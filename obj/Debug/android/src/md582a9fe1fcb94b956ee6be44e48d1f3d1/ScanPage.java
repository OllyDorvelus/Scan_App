package md582a9fe1fcb94b956ee6be44e48d1f3d1;


public class ScanPage
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Scan_Android.ScanPage, Scan Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ScanPage.class, __md_methods);
	}


	public ScanPage ()
	{
		super ();
		if (getClass () == ScanPage.class)
			mono.android.TypeManager.Activate ("Scan_Android.ScanPage, Scan Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
