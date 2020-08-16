from pwn import xor
text = open("enc.bin",'r').read()
print list(bytearray(text))