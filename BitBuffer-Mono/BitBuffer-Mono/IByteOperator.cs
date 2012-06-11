using System;
namespace com.fantaros.lib.bitbuffer
{
	public interface IByteOperator
	{
		byte doOperator(string name,params byte[] val1);
	}
}

