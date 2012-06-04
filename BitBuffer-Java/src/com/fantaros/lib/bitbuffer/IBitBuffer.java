package com.fantaros.lib.bitbuffer;

import java.io.InputStream;

public interface IBitBuffer {

  byte peek(int offset);

  boolean peekOne(int offset);

  void zero();

  void fill();

  void write(String data, int startOffset, int bits);

  void write(byte[] data, int startOffset, int bits);

  void write(InputStream data, int startOffset, int bits);

  Bit range(int startOffset, int bits);

  byte[] getBytes(int startOffset, int bytes);
}
