package system.windows.threading;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DispatcherTimerTask extends java.util.TimerTask implements MonoProxy
{
	static
	{
		MonoBridge.link(DispatcherTimerTask.class, "run", "()V", "");

	}

	public native void run();



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
