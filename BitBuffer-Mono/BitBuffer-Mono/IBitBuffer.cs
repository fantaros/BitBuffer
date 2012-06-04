using System;
using System.IO;
namespace com.fantaros.lib.bitbuffer
{
	public interface IBitBuffer
	{
		byte peek(int offset);
		bool peekOne(int offset);
		void enlarge(int bitsize);
		void empty();
		void fill();
		void write(string data,int startOffset,int bits);
		void write(byte[] data,int startOffset,int bits);
		void write(Stream data,int startOffset,int bits);
		byte[] range(int startOffset,int bits);
	}
}

