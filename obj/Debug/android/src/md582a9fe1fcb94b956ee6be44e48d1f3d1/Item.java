package md582a9fe1fcb94b956ee6be44e48d1f3d1;


public class Item
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.io.Serializable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("Scan_Android.Item, Scan Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Item.class, __md_methods);
	}


	public Item ()
	{
		super ();
		if (getClass () == Item.class)
			mono.android.TypeManager.Activate ("Scan_Android.Item, Scan Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Item (java.lang.String p0, int p1)
	{
		super ();
		if (getClass () == Item.class)
			mono.android.TypeManager.Activate ("Scan_Android.Item, Scan Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

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
