using System;
namespace com.fantaros.lib.bitbuffer
{
	public abstract class BitBuffer : IBitBuffer
	{
		private byte[] data;
		private int bits;
		public BitBuffer (byte[] data, int bits)
		{
			this.data = data;
			this.bits = bits;
		}
		
		public byte peek (int offset)
		{
			int index = offset % 8;
			if (data != null && data.Length > index) {
				
			} else {
				
				return -1;
			}
		}
	}
}

