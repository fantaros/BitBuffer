using System;
using System.Collections.Generic;
namespace com.fantaros.lib.bitbuffer
{
	public class BitBuffer : IList<byte>
	{
		private byte[] data;
		private int bits;
		
		public int Count {
			get{ return data.Length;}
		}
		
		public BitBuffer ()
		{
			data = null;
			bits = 0;
		}
		
		public void empty ()
		{
			if (data != null) {
				for (int i = 0; i<this.data.Length; ++i) {
					this.data [i] = 0;
				}	
			}
		}
		
		public void fill ()
		{
			if (data != null) {
				for (int i = 0; i<this.data.Length; ++i) {
					this.data [i] = 0xff;
				}
			}
		}
		
		public byte getBit(int offset){
			
		}
	}
}

