package system.windows;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WindowActivity extends android.app.Activity implements MonoProxy, android.opengl.GLSurfaceView.Renderer
{
	static
	{
		MonoBridge.link(WindowActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");
		MonoBridge.link(WindowActivity.class, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "javax.microedition.khronos.opengles.GL10,javax.microedition.khronos.egl.EGLConfig");
		MonoBridge.link(WindowActivity.class, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "javax.microedition.khronos.opengles.GL10,System.Int32,System.Int32");
		MonoBridge.link(WindowActivity.class, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "javax.microedition.khronos.opengles.GL10");

	}

	protected native void onCreate(android.os.Bundle arg0);
	public native void onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0,javax.microedition.khronos.egl.EGLConfig arg1);
	public native void onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0,int arg1,int arg2);
	public native void onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0);



	long myGCHandle;
	public long getGCHandle() {{
		return myGCHandle;
	}}

	public void setGCHandle(long gcHandle) {{
		myGCHandle = gcHandle;
	}}

    /*
	@Override
	protected void finalize() throws Throwable {{
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}}
	*/

}
