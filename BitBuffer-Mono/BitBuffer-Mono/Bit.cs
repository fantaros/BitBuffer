using System;
namespace com.fantaros.lib.bitbuffer
{
	public class Bit
	{
		private byte[] data;
		private int bits;
		public Bit (byte[] data, int bits)
		{
			this.data = data;
			this.bits = bits;
		}
	}
}

