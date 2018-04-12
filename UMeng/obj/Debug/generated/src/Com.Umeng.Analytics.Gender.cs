using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']"
	[global::Android.Runtime.Register ("com/umeng/analytics/Gender", DoNotGenerateAcw=true)]
	public partial class Gender : global::Java.Lang.Enum {


		static IntPtr Female_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/field[@name='Female']"
		[Register ("Female")]
		public static global::Com.Umeng.Analytics.Gender Female {
			get {
				if (Female_jfieldId == IntPtr.Zero)
					Female_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Female", "Lcom/umeng/analytics/Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Female_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Male_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/field[@name='Male']"
		[Register ("Male")]
		public static global::Com.Umeng.Analytics.Gender Male {
			get {
				if (Male_jfieldId == IntPtr.Zero)
					Male_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Male", "Lcom/umeng/analytics/Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Male_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Com.Umeng.Analytics.Gender Unknown {
			get {
				if (Unknown_jfieldId == IntPtr.Zero)
					Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lcom/umeng/analytics/Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/analytics/Gender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Gender); }
		}

		protected Gender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getGender_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/method[@name='getGender' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGender", "(I)Lcom/umeng/analytics/Gender;", "")]
		public static unsafe global::Com.Umeng.Analytics.Gender GetGender (int p0)
		{
			if (id_getGender_I == IntPtr.Zero)
				id_getGender_I = JNIEnv.GetStaticMethodID (class_ref, "getGender", "(I)Lcom/umeng/analytics/Gender;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGender_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value;
#pragma warning disable 0169
		static Delegate GetValueHandler ()
		{
			if (cb_value == null)
				cb_value = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Value);
			return cb_value;
		}

		static int n_Value (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Analytics.Gender __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value ();
		}
#pragma warning restore 0169

		static IntPtr id_value;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "GetValueHandler")]
		public virtual unsafe int Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_value);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "()I"));
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/analytics/Gender;", "")]
		public static unsafe global::Com.Umeng.Analytics.Gender ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/analytics/Gender;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Umeng.Analytics.Gender __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='Gender']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/analytics/Gender;", "")]
		public static unsafe global::Com.Umeng.Analytics.Gender[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/analytics/Gender;");
			try {
				return (global::Com.Umeng.Analytics.Gender[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Analytics.Gender));
			} finally {
			}
		}

	}
}
