package md5f78e4fcb18e467f99034745a00b936d7;


public class TeacherScopeAdapter_ItemViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("YbkManage.Adapters.TeacherScopeAdapter+ItemViewHolder, YbkManage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TeacherScopeAdapter_ItemViewHolder.class, __md_methods);
	}


	public TeacherScopeAdapter_ItemViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == TeacherScopeAdapter_ItemViewHolder.class)
			mono.android.TypeManager.Activate ("YbkManage.Adapters.TeacherScopeAdapter+ItemViewHolder, YbkManage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
