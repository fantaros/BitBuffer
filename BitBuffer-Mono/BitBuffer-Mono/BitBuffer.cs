using System;
namespace com.fantaros.lib.bitbuffer
{
	public abstract class BitBuffer : IBitBuffer
	{
		private byte[] data;
		private int bits;
		private bool xand;
		
		public BitBuffer (byte[] data, int bits, bool xand)
		{
			this.data = data;
			this.bits = bits;
			this.xand = xand;
		}
		
		public byte peek (int offset)
		{
			int index = offset % 8;
			if (data != null && data.Length > index) {
				int iindex = 8 - (index * 8 - offset);
				byte org = (byte)(data [index] >> iindex);
				return (byte)(org & 1);
			} else {
				enlarge (offset);
				return -1;
			}
		}
		
		public bool peekOne (int offset)
		{
			byte res = peek (offset);
			if (res == 1) {
				return true;
			}
			else if (res == 0)
			{
				return false;
			} 
			else 
			{
				throw new ArgumentOutOfRangeException (string.Format (
					"{0}(Your request) > {1}(Your current),I have enlarged your buffer size!",
					offset,
					data.Length*8
					));
			}
		}
		
		public void empty ()
		{
			if (data == null) {
				data = new byte[0];
			} else {
				for (int i = 0; i < data.Length; ++i) {
					if (this.xand) {
						data [i] = 0;
					} else {
						data [i] = 0xFF;	
					}
				}
			}
		}
		
		public void enlarge (int bitsize)
		{
			int index = bitsize % 8;
			if (data == null) {
				data = new byte[index];
				empty ();
			} else if (data.Length <= index) {
				byte[] temp = new byte[index];
				int i = 0;
				for (i = 0; i < temp.Length; ++i) {
					if (this.xand) {
						temp [i] = 0;
					} else {
						temp [i] = 0xFF;	
					}
				}
				data.CopyTo (temp,0);
			}
		}
	}
}

