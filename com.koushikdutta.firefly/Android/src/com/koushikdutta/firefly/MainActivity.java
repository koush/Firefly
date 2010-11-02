package com.koushikdutta.firefly;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MainActivity extends system.windows.WindowActivity implements MonoProxy
{
	static
	{
		MonoBridge.link(MainActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");

	}

	protected native void onCreate(android.os.Bundle arg0);



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
